# AWIPS

This application is heavily based off of NOAA'S AWIPS application; all rights reserved. This program is for experimental purposes only and will not function in a real environment.

The C# portion of the program communicates with a Python-based local server to store data involving weather products sent from the application, as well as providing access to such data and managing it in relation to its geographic location and pertinent information.

The application allows polygons to be drawn on a static map, which generates latitude and longitude values. These points are mapped to county and city lines which generates the products, in respect to their FIPS code, as well as set duration from the generation menus. Once the product is sent it is stored on a Python-based server which other portions of the weather system, such as audio transmitters, can access and relay information from the server.

The application contains the following features: WarnGen, NWRWaves, BMH Menu, Local Storm Report, Text Workstation and Text Editor, Transmitter Group Alignment.

WarnGen - generates alert products based off of polygon on map; localized to NWS office assignment.
NWRWaves - view of all active products in the database, in respect to the NWS office issuing the alert.
BMH Menu - allows monitoring and control of the virtual NOAA weather radios operational in relation to the server and the NWS office.
Local Storm Report - allows for easy generation of storm report data for a specific location, as well as magnitude and intensity information.
Text Workstation/Text Editor - allows for editing of text products before sending out.
Transmitter Group Alignment - allows manual callibration of transmitter attributes.
