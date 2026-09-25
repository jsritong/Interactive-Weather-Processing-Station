using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using NetTopologySuite.Geometries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
namespace AWIPS
{
    public partial class AWIPSForm : Form
    {

        private GMapOverlay polygonOverlay;
        private GMapOverlay handleOverlay;
        private GMapOverlay trackOverlay;
        private GMapOverlay deploymentOverlay;

        private List<PointLatLng> polygonVertices = new List<PointLatLng>();
        private List<PointLatLng> trackPoints = new List<PointLatLng>();
        private GMapPolygon warningPolygon;
        private GMapRoute trackLine;

        private GMarkerGoogle deploymentMarker;
        private GMarkerGoogle trackHubMarker;
        private GMarkerGoogle trackHubMarker2;

        private bool isDragging = false;
        private GMapMarker selectedMarker = null;
        private bool isSystemActive = false;
        private int currentFrameIndex = 0;
        private const int totalFrames = 5;
        private GMarkerGoogle currentStormIndicator;
        private List<GeoEntity> geographicDatabase = new List<GeoEntity>();
        public AWIPSForm()
        {
            InitializeComponent();
            InitializeMap();
            ResetWarningSystem();

            lblForecasterName.Text = Globals.forecasterName;
            gMapControl1.MouseDown += Map_MouseDown;
            gMapControl1.MouseMove += Map_MouseMove;
            gMapControl1.MouseUp += Map_MouseUp;
            if (Globals.officeId == "WNS")
            {
                spcIssuancePanel.Visible = true;
                btnWarnGen.Enabled = false;
                warngenToolStripMenuItem.Enabled = false;
                localStormReportToolStripMenuItem.Enabled = false;
            }
        }
        private void InitializeMap()
        {
            gMapControl1.Dock = DockStyle.Fill;
            gMapControl1.MapProvider = ArcGISDarkProvider.Instance;
            GMap.NET.GMaps.Instance.Mode = GMap.NET.AccessMode.ServerAndCache;

            gMapControl1.MinZoom = 2;
            gMapControl1.MaxZoom = 18;
            gMapControl1.Zoom = 5;
            gMapControl1.Position = new PointLatLng(35.2271, -80.8431);
            gMapControl1.CanDragMap = true;
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.DisableFocusOnMouseEnter = true;
            gMapControl1.MouseWheelZoomEnabled = true;
            gMapControl1.IgnoreMarkerOnMouseWheel = true;

            gMapControl1.MouseWheelZoomType = MouseWheelZoomType.MousePositionWithoutCenter;
            polygonOverlay = new GMapOverlay("polygon");
            trackOverlay = new GMapOverlay("track");
            handleOverlay = new GMapOverlay("handles");
            deploymentOverlay = new GMapOverlay("deployment");
            gMapControl1.Overlays.Add(polygonOverlay);
            gMapControl1.Overlays.Add(trackOverlay);
            gMapControl1.Overlays.Add(handleOverlay);
            gMapControl1.Overlays.Add(deploymentOverlay);
        }
        private static readonly HttpClient client = new HttpClient();
        public async Task HarvestDataAutomaticallyFromWeb()
        {
            Globals.bringUpWorkstation = true;
            if (polygonVertices == null || polygonVertices.Count < 4)
            {
                Globals.lstImpactedCities.Clear();
                Globals.lstImpactedCounties.Clear();
                Globals.countiesAffected = string.Empty;
            }
            Globals.LatLonPoints.Clear();
            Globals.TrackLatLonPoints.Clear();
            if (trackPoints.Count > 0)
            {
                double absLat = Math.Abs(trackPoints[0].Lat);
                double absLon = Math.Abs(trackPoints[0].Lng);
                int formattedLat = (int)Math.Round(absLat * 100);
                int formattedLon = (int)Math.Round(absLon * 100);
                string latStr = formattedLat.ToString("D4");
                string lonStr = formattedLon.ToString("D4");
                Globals.TrackLatLonPoints.Add($"{latStr} {lonStr}");
                Globals.centeredLat = latStr;
                Globals.centeredLon = lonStr;
                foreach (var vertex in polygonVertices)
                {
                    absLat = Math.Abs(vertex.Lat);
                    absLon = Math.Abs(vertex.Lng);
                    formattedLat = (int)Math.Round(absLat * 100);
                    formattedLon = (int)Math.Round(absLon * 100);
                    latStr = formattedLat.ToString("D4");
                    lonStr = formattedLon.ToString("D4");
                    Globals.LatLonPoints.Add($"{latStr} {lonStr}");
                }
                if (Globals.stormMode == 1)
                {
                    for (int i = 2; i < trackPoints.Count; i++)
                    {
                        absLat = Math.Abs(trackPoints[i].Lat);
                        absLon = Math.Abs(trackPoints[i].Lng);
                        formattedLat = (int)Math.Round(absLat * 100);
                        formattedLon = (int)Math.Round(absLon * 100);
                        latStr = formattedLat.ToString("D4");
                        lonStr = formattedLon.ToString("D4");
                        Globals.TrackLatLonPoints.Add($"{latStr} {lonStr}");
                    }
                }
                Globals.countiesAffected = string.Empty;
                Globals.countiesAffectedList = new List<string>();
                Globals.lstImpactedCities = new List<string>();
                List<string> closeCitiesNear = new List<string>();
                string url = $"http://{Globals.serverip}/getlocationsaffected/{Globals.username}/{Globals.password}/{string.Join(" ", Globals.LatLonPoints)}/{string.Join(" ", Globals.TrackLatLonPoints)}";
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    response.EnsureSuccessStatusCode();
                    string jsonString = await response.Content.ReadAsStringAsync();
                    using (JsonDocument doc = JsonDocument.Parse(jsonString))
                    {
                        JsonElement root = doc.RootElement;
                        if (root.TryGetProperty("status", out JsonElement statusElement) &&
                            statusElement.GetString() == "success")
                        {
                            if (root.TryGetProperty("counties", out JsonElement statusElement2))
                            {
                                List<string> dataList2 = Convert.ToString(statusElement2).Split(new Char[] { '-' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                                foreach (string data in dataList2)
                                {
                                    Globals.countiesAffectedList.Add(data);
                                }
                            }
                            if (root.TryGetProperty("closeCities", out JsonElement statusElement3))
                            {
                                List<string> dataList3 = Convert.ToString(statusElement3).Split(new Char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                                foreach (string data in dataList3)
                                {
                                    closeCitiesNear.Add(data);
                                }
                                List<NearbyCity> globalNearbyCities = new List<NearbyCity>();
                                {
                                    if (Globals.stormMode == 0)
                                    {
                                        for (int i = 0; i < closeCitiesNear.Count; i += 3)
                                        {
                                            double lat = Convert.ToDouble(closeCitiesNear[i + 1]);
                                            double lng = Convert.ToDouble(closeCitiesNear[i + 2]);
                                            string cityName = closeCitiesNear[i];
                                            PointLatLng cityPos = new PointLatLng(lat, lng);
                                            double distanceInMiles = CalculateDistanceInMiles(trackPoints[0], cityPos);
                                            string dir = GetCompassDirection(cityPos, trackPoints[0]);
                                            if (!globalNearbyCities.Any(c => c.Name == cityName))
                                            {
                                                globalNearbyCities.Add(new NearbyCity { Name = cityName, Distance = distanceInMiles, Direction = dir });
                                            }
                                        }
                                        var nearestToStorm = globalNearbyCities.OrderBy(c => c.Distance).ToList();
                                        string primaryCity = nearestToStorm.Count > 0 ? nearestToStorm[0].Name : "";
                                        string secondaryCity = nearestToStorm.Count > 1 ? nearestToStorm[1].Name : "";
                                        Globals.rawPrimaryLocation = primaryCity;
                                        Globals.primaryLocation = "";
                                        Globals.secondaryLocation = "";
                                        if (nearestToStorm.Count > 0)
                                        {
                                            if (nearestToStorm[0].Distance < 5)
                                            {
                                                Globals.primaryLocation = $"over {primaryCity}";
                                            }
                                            else
                                            {
                                                Globals.primaryLocation = $"{Math.Round(nearestToStorm[0].Distance)} miles {nearestToStorm[0].Direction} of {primaryCity}";
                                            }
                                        }
                                        if (nearestToStorm.Count > 1)
                                        {
                                            if (nearestToStorm[1].Distance > 10)
                                            {
                                                Globals.secondaryLocation = "";
                                            }
                                            else
                                            {
                                                if (nearestToStorm[1].Distance < 5)
                                                {
                                                    Globals.secondaryLocation = $"near {secondaryCity}";
                                                }
                                                else
                                                {
                                                    Globals.secondaryLocation = $"{Math.Round(nearestToStorm[1].Distance)} miles {nearestToStorm[1].Direction} of {secondaryCity}";
                                                }
                                            }
                                        }
                                        Globals.primaryLocationDistance = nearestToStorm.Count > 0 ? nearestToStorm[0].Distance : 99999999999;
                                        Globals.secondaryLocationDistance = nearestToStorm.Count > 1 ? nearestToStorm[1].Distance : 99999999999;
                                    }
                                    else
                                    {
                                        List<string> citiesUsed = new List<string>();
                                        Globals.lineOfStormsCityData.Clear();
                                        for (int i = 0; i < trackPoints.Count; i++)
                                        {
                                            if (i != 1)
                                            {
                                                globalNearbyCities.Clear();
                                                for (int b = 0; b < closeCitiesNear.Count; b += 3)
                                                {
                                                    double lat = Convert.ToDouble(closeCitiesNear[b + 1]);
                                                    double lng = Convert.ToDouble(closeCitiesNear[b + 2]);
                                                    string cityName = closeCitiesNear[b];
                                                    PointLatLng cityPos = new PointLatLng(lat, lng);
                                                    double distanceInMiles = CalculateDistanceInMiles(trackPoints[i], cityPos);
                                                    string dir = GetCompassDirection(cityPos, trackPoints[i]);
                                                    if (!globalNearbyCities.Any(c => c.Name == cityName))
                                                    {
                                                        globalNearbyCities.Add(new NearbyCity { Name = cityName, Distance = distanceInMiles, Direction = dir });
                                                    }
                                                }
                                                var nearestToStorm = globalNearbyCities.OrderBy(c => c.Distance).ToList();
                                                string primaryCity = nearestToStorm.Count > 0 ? nearestToStorm[0].Name : "";
                                                Globals.primaryLocation = "";
                                                if (nearestToStorm.Count > 0)
                                                {
                                                    if (citiesUsed.Contains(primaryCity) || primaryCity == "")
                                                    {
                                                    }
                                                    else
                                                    {
                                                        citiesUsed.Add(primaryCity);
                                                        if (nearestToStorm[0].Distance < 5)
                                                        {
                                                            Globals.primaryLocation = $"near {primaryCity}";
                                                        }
                                                        else
                                                        {
                                                            Globals.primaryLocation = $"{Math.Round(nearestToStorm[0].Distance)} miles {nearestToStorm[0].Direction} of {primaryCity}";
                                                        }
                                                        Globals.lineOfStormsCityData.Add(Globals.primaryLocation);
                                                    }
                                                }
                                                Globals.primaryLocationDistance = nearestToStorm.Count > 0 ? nearestToStorm[0].Distance : 99999999999;
                                            }
                                        }
                                    }
                                }
                                if (root.TryGetProperty("locationsImpacted", out JsonElement statusElement4))
                                {
                                    List<string> dataList4 = Convert.ToString(statusElement4).Split(new Char[] { '|' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                                    for (int i = 0; i < dataList4.Count; i += 3)
                                    {
                                        Globals.lstImpactedCities.Add(dataList4[i]);
                                    }
                                }
                                else
                                {
                                }
                            }
                            else
                            {
                            }

                            string stormHeading = GetCompassDirection(trackPoints[1], trackPoints[0]);
                            string getCompassDirectionName = GetCompassDirectionAngle(trackPoints[0], trackPoints[1]);

                            double fiveMinDistanceMiles = CalculateDistanceInMiles(trackPoints[1], trackPoints[0]);
                            double speedMph = fiveMinDistanceMiles * 12.0;
                            Globals.movementDirecionRounded = stormHeading;
                            Globals.movementSpeed = (int)speedMph;
                            Globals.movementKnots = (int)Math.Round(speedMph / 1.151);
                            Globals.bringUpWorkstation = true;
                        }
                    }
                }
                catch (Exception ex)
                {
                    var confirmResult = MessageBox.Show(
                        $"Failed to query city and county data: {ex}. Do you still want to bring up the text workstation without county or city data?",
                        "Error",
                        MessageBoxButtons.YesNo
                    );
                    if (confirmResult == DialogResult.Yes)
                    {
                        Globals.bringUpWorkstation = true;
                    }
                    else
                    {
                        Globals.bringUpWorkstation = false;
                    }
                    Globals.lstImpactedCities.Clear();
                    Globals.lstImpactedCounties.Clear();
                    Globals.countiesAffected = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please draw a polygon on the map.");
                Globals.bringUpWorkstation = false;
            }
        }
        private double CalculateDistanceInMiles(PointLatLng p1, PointLatLng p2)
        {
            double r = 3958.8;
            double dLat = (p2.Lat - p1.Lat) * Math.PI / 180.0;
            double dLng = (p2.Lng - p1.Lng) * Math.PI / 180.0;
            double a = Math.Sin(dLat / 2.0) * Math.Sin(dLat / 2.0) +
                       Math.Cos(p1.Lat * Math.PI / 180.0) * Math.Cos(p2.Lat * Math.PI / 180.0) *
                       Math.Sin(dLng / 2.0) * Math.Sin(dLng / 2.0);
            double c = 2.0 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1.0 - a));
            return r * c;
        }
        private string GetCompassDirection(PointLatLng cityPos, PointLatLng stormPos)
        {

            double dLng = stormPos.Lng - cityPos.Lng;
            double dLat = stormPos.Lat - cityPos.Lat;

            double angleDeg = Math.Atan2(dLng, dLat) * 180.0 / Math.PI;
            if (angleDeg < 0) angleDeg += 360.0;

            if (angleDeg >= 337.5 || angleDeg < 22.5) return "north";
            if (angleDeg >= 22.5 && angleDeg < 67.5) return "northeast";
            if (angleDeg >= 67.5 && angleDeg < 112.5) return "east";
            if (angleDeg >= 112.5 && angleDeg < 157.5) return "southeast";
            if (angleDeg >= 157.5 && angleDeg < 202.5) return "south";
            if (angleDeg >= 202.5 && angleDeg < 247.5) return "southwest";
            if (angleDeg >= 247.5 && angleDeg < 292.5) return "west";
            if (angleDeg >= 292.5 && angleDeg < 337.5) return "northwest";
            return "";
        }
        private string GetCompassDirectionAngle(PointLatLng cityPos, PointLatLng stormPos)
        {

            double dLng = stormPos.Lng - cityPos.Lng;
            double dLat = stormPos.Lat - cityPos.Lat;

            double angleDeg = Math.Atan2(dLng, dLat) * 180.0 / Math.PI;
            if (angleDeg < 0) angleDeg += 360.0;
            Globals.movementDirection = (int)angleDeg;
            return "";
        }
        public void ResetWarningSystem()
        {
            isSystemActive = false;

            polygonOverlay.Polygons.Clear();
            trackOverlay.Routes.Clear();
            trackOverlay.Markers.Clear();
            handleOverlay.Markers.Clear();

            polygonVertices.Clear();
            trackPoints.Clear();


            deploymentOverlay.Markers.Clear();
            GMapMarker deploymentMarker = new GMarkerOrb(gMapControl1.Position)
            {
                ToolTipText = "Drag me to the storm",
                ToolTipMode = MarkerTooltipMode.Always,
                Tag = "DEPLOYMENT_POINT"
            };
            deploymentOverlay.Markers.Add(deploymentMarker);
            gMapControl1.Refresh();
        }
        public void regenPolygonFromUpdate(string latlonpoly, string timemotloc)
        {
            trackPoints.Clear();
            deploymentOverlay.Markers.Clear();
            ResetWarningSystem();
            if (timemotloc != "")
            {
                List<string> stormMotionLoc = timemotloc.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                double latitude = Convert.ToInt32(stormMotionLoc[3]) / 100.0;
                double longitude = Convert.ToInt32(stormMotionLoc[3 + 1]) / -100.0;
                PointLatLng currentPos = new PointLatLng(latitude, longitude);
                DeployWarningSystem(currentPos);
                deploymentOverlay.Markers.Clear();
                trackOverlay.Markers.Clear();
                GMapMarker deploymentMarker = new GMarkerOrb(currentPos)
                {
                    ToolTipText = "Drag me to the storm",
                    ToolTipMode = MarkerTooltipMode.Always,
                    Tag = "DEPLOYMENT_POINT"
                };
                deploymentOverlay.Markers.Add(deploymentMarker);
                PointLatLng futurePos = CalculateFuturePoint(currentPos, stormMotionLoc[1], stormMotionLoc[2]);
                trackPoints[1] = futurePos;
                GMapMarker trackHubMarker = new GMarkerOrb(trackPoints[1])
                {
                    ToolTipText = "-5 minutes from now",
                    ToolTipMode = MarkerTooltipMode.OnMouseOver,
                    Tag = "TRACK_HUB"
                };
                trackOverlay.Markers.Add(trackHubMarker);
                if (stormMotionLoc.Count > 5)
                {
                    Globals.stormMode = 1;
                }
                else
                {
                    Globals.stormMode = 0;
                }
                for (int i = 5; i < stormMotionLoc.Count; i += 2)
                {
                    latitude = Convert.ToInt32(stormMotionLoc[i]) / 100.0;
                    longitude = Convert.ToInt32(stormMotionLoc[i + 1]) / -100.0;
                    currentPos = new PointLatLng(latitude, longitude);
                    trackPoints.Add(currentPos);
                    GMapMarker lineNodeMarker = new GMarkerOrb(currentPos)
                    {
                        ToolTipText = "",
                        ToolTipMode = MarkerTooltipMode.Always,
                        Tag = $"DEPLOYMENT_POINT_{trackPoints.Count - 1}"
                    };
                    trackOverlay.Markers.Add(lineNodeMarker);
                }
            }
            else
            {
                List<string> stormMotionLoc = "2308Z 246DEG 25KT 3372 8462".Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
                double latitude = Convert.ToInt32(stormMotionLoc[3]) / 100.0;
                double longitude = Convert.ToInt32(stormMotionLoc[3 + 1]) / -100.0;
                PointLatLng currentPos = new PointLatLng(latitude, longitude);
                DeployWarningSystem(currentPos);
                deploymentOverlay.Markers.Clear();
                trackOverlay.Markers.Clear();
                GMapMarker deploymentMarker = new GMarkerOrb(currentPos)
                {
                    ToolTipText = "Drag me to the storm",
                    ToolTipMode = MarkerTooltipMode.Always,
                    Tag = "DEPLOYMENT_POINT"
                };
                deploymentOverlay.Markers.Add(deploymentMarker);
                PointLatLng futurePos = CalculateFuturePoint(currentPos, stormMotionLoc[1], stormMotionLoc[2]);
                trackPoints[1] = futurePos;
                GMapMarker trackHubMarker = new GMarkerOrb(trackPoints[1])
                {
                    ToolTipText = "-5 minutes from now",
                    ToolTipMode = MarkerTooltipMode.OnMouseOver,
                    Tag = "TRACK_HUB"
                };
                trackOverlay.Markers.Add(trackHubMarker);
                if (stormMotionLoc.Count > 5)
                {
                    Globals.stormMode = 1;
                }
                else
                {
                    Globals.stormMode = 0;
                }
                for (int i = 5; i < stormMotionLoc.Count; i += 2)
                {
                    latitude = Convert.ToInt32(stormMotionLoc[i]) / 100.0;
                    longitude = Convert.ToInt32(stormMotionLoc[i + 1]) / -100.0;
                    currentPos = new PointLatLng(latitude, longitude);
                    trackPoints.Add(currentPos);
                    GMapMarker lineNodeMarker = new GMarkerOrb(currentPos)
                    {
                        ToolTipText = "",
                        ToolTipMode = MarkerTooltipMode.Always,
                        Tag = $"DEPLOYMENT_POINT_{trackPoints.Count - 1}"
                    };
                    trackOverlay.Markers.Add(lineNodeMarker);
                }
            }
            polygonVertices.Clear();
            List<string> polygonPlots = latlonpoly.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < polygonPlots.Count; i += 2)
            {
                double latitude = Convert.ToInt32(polygonPlots[i]) / 100.0;
                double longitude = Convert.ToInt32(polygonPlots[i + 1]) / -100.0;
                PointLatLng polygonLatLng = new PointLatLng(latitude, longitude);
                polygonVertices.Add(polygonLatLng);
            }
            UpdateVertexHandles();
            gMapControl1.Refresh();
        }
        public PointLatLng CalculateFuturePoint(PointLatLng initialPos, string degStr, string ktStr)
        {

            double degrees = double.Parse(Regex.Match(degStr, @"\d+").Value);
            double knots = double.Parse(Regex.Match(ktStr, @"\d+").Value);

            double mph = knots * 1.15078;
            double distanceMiles = mph * (5.0 / 60.0);
            double earthRadiusMiles = 3959.0;

            double lat1 = initialPos.Lat * (Math.PI / 180.0);
            double lon1 = initialPos.Lng * (Math.PI / 180.0);
            double bearing = degrees * (Math.PI / 180.0);

            double angularDistance = distanceMiles / earthRadiusMiles;

            double lat2 = Math.Asin(Math.Sin(lat1) * Math.Cos(angularDistance) +
                                    Math.Cos(lat1) * Math.Sin(angularDistance) * Math.Cos(bearing));
            double lon2 = lon1 + Math.Atan2(Math.Sin(bearing) * Math.Sin(angularDistance) * Math.Cos(lat1),
                                            Math.Cos(angularDistance) - Math.Sin(lat1) * Math.Sin(lat2));

            double finalLat = lat2 * (180.0 / Math.PI);
            double finalLon = lon2 * (180.0 / Math.PI);
            return new PointLatLng(finalLat, finalLon);
        }
        public void RecalculateTrackFromMarkers()
        {
            if (Globals.stormMode == 0)
            {
                if (trackPoints.Count < 2) return;


                PointLatLng currentPos = trackPoints[0];
                PointLatLng pastPos = trackPoints[1];

                double dLng = (currentPos.Lng - pastPos.Lng);
                double dLat = (currentPos.Lat - pastPos.Lat);
                double angleRad = Math.Atan2(dLat, dLng);

                double fiveMinDistance = Math.Sqrt(dLat * dLat + dLng * dLng);

                int totalDurationMinutes = Globals.warngenDurationsList[Globals.durationSelected];
                double frameIntervalMinutes = 5.0;
                double multiplier = totalDurationMinutes / frameIntervalMinutes;

                double futureDistance = fiveMinDistance * multiplier;
                double futureLat = currentPos.Lat + (futureDistance * Math.Sin(angleRad));
                double futureLng = currentPos.Lng + (futureDistance * Math.Cos(angleRad));
                PointLatLng futureEndPoint = new PointLatLng(futureLat, futureLng);

                trackLine.Points.Clear();
                trackLine.Points.Add(currentPos);
                trackLine.Points.Add(futureEndPoint);
                gMapControl1.UpdateRouteLocalPosition(trackLine);

                double perpAngleRad = angleRad + (Math.PI / 2.0);


                double executionDistance = Math.Max(futureDistance, 0.05);

                double baseHalfWidth = executionDistance * 0.15;
                double forwardHalfWidth = executionDistance * 0.30;

                double baseLatOffset = baseHalfWidth * Math.Sin(perpAngleRad);
                double baseLngOffset = baseHalfWidth * Math.Cos(perpAngleRad);
                PointLatLng backLeft = new PointLatLng(currentPos.Lat + baseLatOffset, currentPos.Lng + baseLngOffset);
                PointLatLng backRight = new PointLatLng(currentPos.Lat - baseLatOffset, currentPos.Lng - baseLngOffset);

                double forwardLatOffset = forwardHalfWidth * Math.Sin(perpAngleRad);
                double forwardLngOffset = forwardHalfWidth * Math.Cos(perpAngleRad);
                PointLatLng frontLeft = new PointLatLng(futureEndPoint.Lat + forwardLatOffset, futureEndPoint.Lng + forwardLngOffset);
                PointLatLng frontRight = new PointLatLng(futureEndPoint.Lat - forwardLatOffset, futureEndPoint.Lng - forwardLngOffset);

                polygonVertices.Clear();
                polygonVertices.Add(backLeft);
                polygonVertices.Add(frontLeft);
                polygonVertices.Add(frontRight);
                polygonVertices.Add(backRight);

                UpdateVertexHandles();
                gMapControl1.Refresh();
            }
            else
            {

                if (trackPoints.Count < 2) return;

                PointLatLng masterCurrent = trackPoints[0];
                PointLatLng masterPast = trackPoints[1];
                double dLng = (masterCurrent.Lng - masterPast.Lng);
                double dLat = (masterCurrent.Lat - masterPast.Lat);
                double angleRad = Math.Atan2(dLat, dLng);

                double fiveMinDistance = Math.Sqrt(dLat * dLat + dLng * dLng);

                int totalDurationMinutes = Globals.warngenDurationsList[Globals.durationSelected];
                double frameIntervalMinutes = 5.0;
                double multiplier = totalDurationMinutes / frameIntervalMinutes;
                double futureDistance = fiveMinDistance * multiplier;

                double latShift = futureDistance * Math.Sin(angleRad);
                double lngShift = futureDistance * Math.Cos(angleRad);


                List<PointLatLng> currentLinePoints = new List<PointLatLng>();
                currentLinePoints.Add(masterCurrent);
                for (int i = 2; i < trackPoints.Count; i++)
                {
                    currentLinePoints.Add(trackPoints[i]);
                }

                List<PointLatLng> futurePoints = new List<PointLatLng>();
                foreach (PointLatLng currentPos in currentLinePoints)
                {
                    double futureLat = currentPos.Lat + latShift;
                    double futureLng = currentPos.Lng + lngShift;
                    futurePoints.Add(new PointLatLng(futureLat, futureLng));
                }

                trackLine.Points.Clear();
                trackLine.Points.Add(masterCurrent);
                trackLine.Points.Add(futurePoints[0]);
                gMapControl1.UpdateRouteLocalPosition(trackLine);

                polygonVertices.Clear();

                polygonVertices.AddRange(currentLinePoints);

                for (int i = futurePoints.Count - 1; i >= 0; i--)
                {
                    polygonVertices.Add(futurePoints[i]);
                }

                UpdateVertexHandles();
                gMapControl1.Refresh();
            }
        }
        public void RecalculateTrackFromMarkers2()
        {
            if (Globals.stormMode == 0)
            {
                if (trackPoints.Count < 2) return;


                PointLatLng currentPos = trackPoints[0];
                PointLatLng pastPos = trackPoints[1];

                double dLng = (currentPos.Lng - pastPos.Lng);
                double dLat = (currentPos.Lat - pastPos.Lat);
                double angleRad = Math.Atan2(dLat, dLng);

                double fiveMinDistance = Math.Sqrt(dLat * dLat + dLng * dLng);

                int totalDurationMinutes = Globals.warngenDurationsList[Globals.durationSelected];
                double frameIntervalMinutes = 5.0;
                double multiplier = totalDurationMinutes / frameIntervalMinutes;

                double futureDistance = fiveMinDistance * multiplier;
                double futureLat = currentPos.Lat;
                double futureLng = currentPos.Lng;
                PointLatLng futureEndPoint = new PointLatLng(futureLat, futureLng);

                trackLine.Points.Clear();
                trackLine.Points.Add(currentPos);
                trackLine.Points.Add(futureEndPoint);
                gMapControl1.UpdateRouteLocalPosition(trackLine);

                double perpAngleRad = angleRad + (Math.PI / 2.0);


                double executionDistance = Math.Max(futureDistance, 0.05);

                double baseHalfWidth = executionDistance * 0.12;
                double forwardHalfWidth = executionDistance * 0.35;

                double baseLatOffset = 0.001;
                double baseLngOffset = 0.001;
                PointLatLng backLeft = new PointLatLng(currentPos.Lat + baseLatOffset, currentPos.Lng + baseLngOffset);
                PointLatLng backRight = new PointLatLng(currentPos.Lat - baseLatOffset, currentPos.Lng - baseLngOffset);

                double forwardLatOffset = 0.001;
                double forwardLngOffset = 0.001;
                PointLatLng frontLeft = new PointLatLng(futureEndPoint.Lat + forwardLatOffset, futureEndPoint.Lng + forwardLngOffset);
                PointLatLng frontRight = new PointLatLng(futureEndPoint.Lat - forwardLatOffset, futureEndPoint.Lng - forwardLngOffset);

                polygonVertices.Clear();
                polygonVertices.Add(backLeft);
                polygonVertices.Add(frontLeft);
                polygonVertices.Add(frontRight);
                polygonVertices.Add(backRight);

                UpdateVertexHandles();
                gMapControl1.Refresh();
            }
            else
            {

                if (trackPoints.Count < 2) return;

                PointLatLng masterCurrent = trackPoints[0];
                PointLatLng masterPast = trackPoints[1];
                double dLng = (masterCurrent.Lng - masterPast.Lng);
                double dLat = (masterCurrent.Lat - masterPast.Lat);
                double angleRad = Math.Atan2(dLat, dLng);

                double fiveMinDistance = Math.Sqrt(dLat * dLat + dLng * dLng);

                int totalDurationMinutes = Globals.warngenDurationsList[Globals.durationSelected];
                double frameIntervalMinutes = 5.0;
                double multiplier = totalDurationMinutes / frameIntervalMinutes;
                double futureDistance = fiveMinDistance * multiplier;

                double latShift = futureDistance * Math.Sin(angleRad);
                double lngShift = futureDistance * Math.Cos(angleRad);


                List<PointLatLng> currentLinePoints = new List<PointLatLng>();
                currentLinePoints.Add(masterCurrent);
                for (int i = 2; i < trackPoints.Count; i++)
                {
                    currentLinePoints.Add(trackPoints[i]);
                }

                List<PointLatLng> futurePoints = new List<PointLatLng>();
                foreach (PointLatLng currentPos in currentLinePoints)
                {
                    double futureLat = currentPos.Lat + latShift;
                    double futureLng = currentPos.Lng + lngShift;
                    futurePoints.Add(new PointLatLng(futureLat, futureLng));
                }

                trackLine.Points.Clear();
                trackLine.Points.Add(masterCurrent);
                trackLine.Points.Add(futurePoints[0]);
                gMapControl1.UpdateRouteLocalPosition(trackLine);

                polygonVertices.Clear();

                polygonVertices.AddRange(currentLinePoints);

                for (int i = futurePoints.Count - 1; i >= 0; i--)
                {
                    polygonVertices.Add(futurePoints[i]);
                }

                UpdateVertexHandles();
                gMapControl1.Refresh();
            }
        }
        private void DeployWarningSystem(PointLatLng spawnPoint)
        {
            isSystemActive = true;

            polygonVertices.Add(new PointLatLng(spawnPoint.Lat - 0.15, spawnPoint.Lng - 0.15));
            polygonVertices.Add(new PointLatLng(spawnPoint.Lat + 0.15, spawnPoint.Lng - 0.15));
            polygonVertices.Add(new PointLatLng(spawnPoint.Lat + 0.30, spawnPoint.Lng + 0.30));
            polygonVertices.Add(new PointLatLng(spawnPoint.Lat - 0.00, spawnPoint.Lng + 0.30));
            warningPolygon = new GMapPolygon(polygonVertices, "WarnGenBox")
            {
                Fill = new SolidBrush(Color.FromArgb(40, Color.White)),
                Stroke = new Pen(Color.White, 2)
            };
            polygonOverlay.Polygons.Add(warningPolygon);

            trackPoints.Add(spawnPoint);
            trackPoints.Add(new PointLatLng(spawnPoint.Lat - 0.02, spawnPoint.Lng - 0.02));
            trackLine = new GMapRoute(trackPoints, "TrackVector")
            {
                Stroke = new Pen(Color.White, 2) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash }
            };
            trackOverlay.Routes.Add(trackLine);

            GMapMarker trackHubMarker = new GMarkerOrb(trackPoints[1])
            {
                ToolTipText = "-5 minutes from now",
                ToolTipMode = MarkerTooltipMode.OnMouseOver,
                Tag = "TRACK_HUB"
            };
            trackOverlay.Markers.Add(trackHubMarker);

            UpdateVertexHandles();
            gMapControl1.Refresh();
        }
        private void UpdateVertexHandles()
        {
            if (warningPolygon != null)
            {
                warningPolygon.Points.Clear();
                warningPolygon.Points.AddRange(polygonVertices);
                gMapControl1.UpdatePolygonLocalPosition(warningPolygon);
            }
            handleOverlay.Markers.Clear();
            for (int i = 0; i < polygonVertices.Count; i++)
            {
                var handle = new GMarkerTriangle(polygonVertices[i])
                {
                    Tag = $"POLYGON_MARKER_{i}"
                };
                handleOverlay.Markers.Add(handle);
            }
        }
        #region Drag Interaction Framework
        private void Map_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                GMapMarker item = null;


                item = GetMarkerHitTest(deploymentOverlay, e.X, e.Y);




                if (item == null) item = GetMarkerHitTest(trackOverlay, e.X, e.Y);
                if (item == null) item = GetMarkerHitTest(handleOverlay, e.X, e.Y);

                if (item != null)
                {
                    isDragging = true;
                    selectedMarker = item;
                    gMapControl1.CanDragMap = false;
                }
            }
            if (e.Button == MouseButtons.Middle)
            {

                PointLatLng clickedPosition = gMapControl1.FromLocalToLatLng(e.X, e.Y);

                if (trackPoints.Count < 2)
                {
                    MessageBox.Show("Please place the primary storm position and past movement indicator first!",
                                    "Anchor Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                GPoint clickedPixel = gMapControl1.FromLatLngToLocal(clickedPosition);
                double pixelThreshold = 8.0;
                bool pointInserted = false;


                int totalFrontLineNodes = trackPoints.Count - 1;
                for (int i = 0; i < polygonVertices.Count; i++)
                {
                    int nextIdx = (i + 1) % polygonVertices.Count;
                    GPoint pixelA = gMapControl1.FromLatLngToLocal(polygonVertices[i]);
                    GPoint pixelB = gMapControl1.FromLatLngToLocal(polygonVertices[nextIdx]);
                    if (FindDistanceToSegment(clickedPixel, pixelA, pixelB, out GPoint closestPoint))
                    {
                        double distance = Math.Sqrt(Math.Pow(clickedPixel.X - closestPoint.X, 2) +
                                                    Math.Pow(clickedPixel.Y - closestPoint.Y, 2));
                        if (distance <= pixelThreshold)
                        {

                            PointLatLng insertionCoords = gMapControl1.FromLocalToLatLng((int)closestPoint.X, (int)closestPoint.Y);

                            if (i == 0)
                            {

                                trackPoints.Insert(2, insertionCoords);
                            }
                            else if (i < totalFrontLineNodes - 1)
                            {

                                trackPoints.Insert(i + 1, insertionCoords);
                            }
                            else
                            {



                                trackPoints.Add(insertionCoords);
                            }
                            pointInserted = true;
                            break;
                        }
                    }
                }

                if (!pointInserted)
                {
                    if (Globals.stormMode == 1)
                    {
                        if (trackPoints.Count < 2)
                        {
                            MessageBox.Show("Please place the primary storm position and past movement indicator first!",
                                            "Anchor Missing", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        trackPoints.Add(clickedPosition);

                        int newIndex = trackPoints.Count - 1;

                        GMapMarker lineNodeMarker = new GMarkerOrb(clickedPosition)
                        {
                            ToolTipText = "",
                            ToolTipMode = MarkerTooltipMode.Always,
                            Tag = $"DEPLOYMENT_POINT_{newIndex}"
                        };

                        trackOverlay.Markers.Add(lineNodeMarker);
                    }
                }
                else
                {
                    return;
                }
                UpdateVertexHandles();
                gMapControl1.Refresh();
            }
        }
        private bool FindDistanceToSegment(GPoint pt, GPoint p1, GPoint p2, out GPoint closest)
        {
            closest = new GPoint();
            double dx = p2.X - p1.X;
            double dy = p2.Y - p1.Y;

            if (Math.Abs(dx) < 0.00001 && Math.Abs(dy) < 0.00001)
            {
                closest = p1;
                return true;
            }

            double u = ((pt.X - p1.X) * dx + (pt.Y - p1.Y) * dy) / (dx * dx + dy * dy);

            if (u < 0) closest = p1;
            else if (u > 1) closest = p2;
            else
            {
                closest = new GPoint((long)(p1.X + u * dx), (long)(p1.Y + u * dy));
            }
            return true;
        }
        private void Map_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && selectedMarker != null)
            {
                PointLatLng mouseCoord = gMapControl1.FromLocalToLatLng(e.X, e.Y);
                selectedMarker.Position = mouseCoord;
                string markerTagString = selectedMarker.Tag?.ToString();
                if (markerTagString == "DEPLOYMENT_POINT")
                {
                    gMapControl1.Refresh();
                }
                else if (markerTagString == "TRACK_HUB")
                {
                    if (trackPoints.Count >= 2)
                    {
                        trackPoints[1] = mouseCoord;
                    }
                }
                else if (markerTagString.Contains("DEPLOYMENT_POINT_"))
                {

                    string indexString = markerTagString.Split(new string[] { "LOYMENT_POINT_" }, StringSplitOptions.None)[1];

                    if (int.TryParse(indexString, out int indexToUpdate))
                    {

                        if (indexToUpdate >= 0 && indexToUpdate < trackPoints.Count)
                        {
                            trackPoints[indexToUpdate] = mouseCoord;
                        }
                    }
                }
                else if (markerTagString.Contains("POLYGON_MARKER_"))
                {

                    string indexString = markerTagString.Split(new string[] { "LYGON_MARKER_" }, StringSplitOptions.None)[1];

                    if (int.TryParse(indexString, out int indexToUpdate))
                    {

                        if (indexToUpdate >= 0 && indexToUpdate < polygonVertices.Count)
                        {
                            polygonVertices[indexToUpdate] = mouseCoord;
                        }
                    }
                }
            }
            UpdateVertexHandles();
            gMapControl1.Refresh();
        }
        private void Map_MouseUp(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                if (selectedMarker != null && selectedMarker.Tag?.ToString() == "DEPLOYMENT_POINT")
                {

                    if (!isSystemActive)
                    {
                        DeployWarningSystem(selectedMarker.Position);
                    }
                    else
                    {
                        trackPoints[0] = selectedMarker.Position;
                    }
                }
                isDragging = false;
                selectedMarker = null;
                gMapControl1.CanDragMap = true;
            }
        }
        private GMapMarker GetMarkerHitTest(GMapOverlay overlay, int x, int y)
        {
            foreach (var marker in overlay.Markers)
            {
                GPoint pos = gMapControl1.FromLatLngToLocal(marker.Position);
                if (Math.Abs(x - pos.X) <= 15 && Math.Abs(y - pos.Y) <= 15) return marker;
            }
            return null;
        }
        #endregion
        private void aboutCAVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About AboutForm = new About(this);
            AboutForm.Show(this);
        }
        private void AWIPS_Load(object sender, EventArgs e)
        {

            this.KeyPreview = true;
            this.KeyDown += AWIPSForm_KeyDown;
        }
        private void AWIPSForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (!isSystemActive || trackPoints.Count < 2) return;
            if (e.KeyCode == Keys.Right)
            {

                if (currentFrameIndex < totalFrames - 1)
                {
                    currentFrameIndex++;
                    UpdateTimelineFrame();
                }
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Left)
            {

                if (currentFrameIndex > 0)
                {
                    currentFrameIndex--;
                    UpdateTimelineFrame();
                }
                e.Handled = true;
            }
        }
        private void UpdateTimelineFrame()
        {
            if (trackPoints.Count < 2) return;
            PointLatLng start = trackPoints[0];
            PointLatLng end = trackPoints[1];

            double fraction = (double)currentFrameIndex / (totalFrames - 1);
            double lat = start.Lat + (end.Lat - start.Lat) * fraction;
            double lng = start.Lng + (end.Lng - start.Lng) * fraction;
            PointLatLng currentFramePosition = new PointLatLng(lat, lng);

            if (currentStormIndicator == null)
            {
                currentStormIndicator = new GMarkerGoogle(currentFramePosition, GMarkerGoogleType.blue_small)
                {
                    ToolTipText = $"Frame {currentFrameIndex}",
                    ToolTipMode = MarkerTooltipMode.OnMouseOver
                };
                trackOverlay.Markers.Add(currentStormIndicator);
            }
            else
            {
                currentStormIndicator.Position = currentFramePosition;
                currentStormIndicator.ToolTipText = $"Frame {currentFrameIndex}";
            }
            gMapControl1.Refresh();


        }
        private void warngenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WarnGen WarnGenForm = new WarnGen(this);
            WarnGenForm.Show(this);
        }
        private void textWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Globals.startEditor = 0;
            Globals.productText = string.Empty;
            Globals.productCategory = "";
            Globals.productDesignator = Globals.officeId;
            Globals.productOriginator = 0;
            Globals.SAMETonage = false;
            Globals.Tonage1050 = false;
            Globals.Interrupt = false;
            Globals.Repeat = false;
            Globals.countiesAffected = "-";
            TextEditor TextEditorForm = new TextEditor();
            TextEditorForm.Show();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void warnGenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            WarnGen WarnGenForm = new WarnGen(this);
            WarnGenForm.Show(this);
        }
        private void vRShearToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void broadcastCycleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BMHMenu BMHMenuForm = new BMHMenu();
            BMHMenuForm.Show();
        }
        private void nWRWavesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NWRWaves NWRWavesForm = new NWRWaves();
            NWRWavesForm.Show();
        }
        private void gMapControl1_Load(object sender, EventArgs e)
        {
        }
        private void lblForecasterName_Click(object sender, EventArgs e)
        {
            ForecasterInfo ForecasterInfoForm = new ForecasterInfo();
            ForecasterInfoForm.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            WarnGen WarnGenForm = new WarnGen(this);
            WarnGenForm.Show(this);
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            AWIPSForm AWIPSFormForm = new AWIPSForm();
            AWIPSFormForm.Show();
        }
        private void tToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        private void broadcastCycleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BMHMenu BMHMenuForm = new BMHMenu();
            BMHMenuForm.Show();
        }
        private void transmitterGroupAlignmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TransmitterGroupAlignment TransmitterGroupAlignmentForm = new TransmitterGroupAlignment();
            TransmitterGroupAlignmentForm.Show();
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            SPCIssuancePanel SPCIssuancePanelForm = new SPCIssuancePanel(this);
            SPCIssuancePanelForm.Show(this);
        }
        private void textWorkstationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextWorkstation TextWorkstationForm = new TextWorkstation(this);
            TextWorkstationForm.Show(this);
        }
        private void localStormReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LocalStormReport LocalStormReportForm = new LocalStormReport(this);
            LocalStormReportForm.Show(this);
        }
    }
    public class GMarkerTriangle : GMapMarker
    {
        private readonly int size = 12;
        public GMarkerTriangle(PointLatLng p) : base(p)
        {

            Size = new Size(size, size);
            Offset = new System.Drawing.Point(-size / 2, -size / 2);
        }
        public override void OnRender(Graphics g)
        {

            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            System.Drawing.Point[] points = new System.Drawing.Point[]
            {
                new System.Drawing.Point(LocalPosition.X + size / 2, LocalPosition.Y),
                new System.Drawing.Point(LocalPosition.X, LocalPosition.Y + size),
                new System.Drawing.Point(LocalPosition.X + size, LocalPosition.Y + size)
            };

            using (Pen pen = new Pen(Color.White, 2))
            {
                g.DrawPolygon(pen, points);
            }
        }
    }

    public class GeoEntity
    {
        public string Name { get; set; }
        public PointLatLng Coordinates { get; set; }
        public string CountyName { get; set; }
        public GeoEntity(string name, PointLatLng coords, string county)
        {
            Name = name;
            Coordinates = coords;
            CountyName = county;
        }
    }
    public class NearbyCity
    {
        public string Name { get; set; }
        public double Distance { get; set; }
        public string Direction { get; set; }
    }
    public class ArcGISDarkProvider : GMapProvider
    {
        public static readonly ArcGISDarkProvider Instance = new ArcGISDarkProvider();
        private ArcGISDarkProvider()
        {
            MaxZoom = 18;
            MinZoom = 1;
        }
        private readonly Guid id = new Guid("4A6B7C8D-9E0F-1A2B-3C4D-5E6F7A8B9C0D");
        public override Guid Id => id;
        public override string Name => "ArcGIS_Dark_Canvas";
        private GMapProvider[] overlays;
        public override GMapProvider[] Overlays
        {
            get
            {
                if (overlays == null)
                {
                    overlays = new GMapProvider[] { this };
                }
                return overlays;
            }
        }

        public override PureProjection Projection => GMap.NET.Projections.MercatorProjection.Instance;

        public override PureImage GetTileImage(GPoint pos, int zoom)
        {
            string url = $"https://server.arcgisonline.com/ArcGIS/rest/services/Canvas/World_Dark_Gray_Base/MapServer/tile/{zoom}/{pos.Y}/{pos.X}";

            return GetTileImageUsingHttp(url);
        }
    }
    public class CityData
    {
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
    }
    public class CountyData
    {
        public string Name { get; set; }
        public Polygon Polygon { get; set; }
    }
}
public class GMarkerOrb : GMapMarker
{

    private System.Drawing.Size _markerSize = new System.Drawing.Size(20, 20);
    public GMarkerOrb(PointLatLng p) : base(p)
    {

        this.Offset = new System.Drawing.Point(-_markerSize.Width / 2, -_markerSize.Height / 2);
    }
    public override void OnRender(Graphics g)
    {

        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        int posX = this.LocalPosition.X;
        int posY = this.LocalPosition.Y;

        using (Pen whitePen = new Pen(Color.White, 2))
        {
            g.DrawEllipse(whitePen, posX, posY, _markerSize.Width, _markerSize.Height);
        }

        using (SolidBrush whiteBrush = new SolidBrush(Color.White))
        {
            int padding = 5;
            int innerWidth = _markerSize.Width - (padding * 2);
            int innerHeight = _markerSize.Height - (padding * 2);
            g.FillEllipse(whiteBrush,
                posX + padding,
                posY + padding,
                innerWidth,
                innerHeight);
        }
    }
}