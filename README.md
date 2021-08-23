# ArcObjects .NET 10.8 SDK Walkthrough Solutions in ArcMap 10.6.x
## General Information
This repository hosts my solutions to the ArcObjects .NET 10.8 SDK walkthroughs. The solutions were created using the ArcObjects .NET *10.6* SDK, which works similarly enough to the 10.8 SDK. You can find all of the walkthroughs [here](https://desktop.arcgis.com/en/arcobjects/latest/net/webframe.htm#welcome.htm) within the online help documentation.

The solutions will include the resulting .esriAddIn files and the CSharp code used to generate the .esriAddIn files. The walkthroughs provided through ESRI should provide enough information to show how the .esriAddIn file is generated and how to use the add-in inside of ArcMap. Refer to the [first walkthrough](https://desktop.arcgis.com/en/arcobjects/latest/net/webframe.htm#WalthroughBuildingCustomUIElementsUsingAdd-Ins.htm) for an extended example.

This is an ongoing project. More solutions to walkthroughs will be added to this repository along the way.

## Requirements
Here are the basic requirements to complete these walkthroughs using ArcMap 10.6.x:
* .NET Framework 4.5 or higher
* Microsoft Visual Studio Community 2017
* ArcMap 10.6.x (with necessary extension access, e. g. Spatial Analyst)
* ArcObjects SDK (.NET) 10.6 (depreciated, must request download by using a My ESRI account with proper credentials) 

## Basic Instructions
- [ ] Describe the usage of the cs files
How to use my solutions:
1. Create an Add-In Project by following the instructions of the first walkthrough
2. Copy/Paste CS code provided in walkthroughs
3. Build solution in VS 2017
4. Click Start in VS 2017 to open ArcMap 10.6

Note: Use the walkthrough instructions to build your own. The troubleshooting section will help with doing this.

## Troubleshooting 
- [ ] Add short write-up on some troubleshooting experiences

The following are examples of some troubleshooting that was done while working through these walkthroughs:
1. ArcObjects snippets have to be copied to another folder and added for usage in the Code Snippets Manager inside of Visual Studio 2017.
2. Set interop to false - https://gis.stackexchange.com/questions/298043/setting-embed-interop-types-in-arcobjects-to-true-or-false
3. Set Debug - https://desktop.arcgis.com/en/arcobjects/latest/net/webframe.htm#HowtoDebugAdd-Ins.htm

## Selected Resources
Here are links to some of the resources that were used to complete the walkthroughs:
* [ArcObjects Help for .NET developers (ArcObjects .NET 10.8 SDK)](https://desktop.arcgis.com/en/arcobjects/latest/net/webframe.htm#welcome.htm)
* [ArcGIS Resource Center - ArcObjects SDK 10 Microsoft .NET Framework](https://help.arcgis.com/en/sdk/10.0/arcobjects_net/componenthelp/)
* [Introduction to ArcObjects (IGIS) 01 Getting to know ArcObjects](https://www.youtube.com/watch?v=piUiYPkfE_s&list=WL&index=5)

Here are the links to the individual walkthrough tutorials completed so far:
* [Walkthrough1 - Building custom UI elements using add-ins (ArcObjects .NET 10.8 SDK)](https://desktop.arcgis.com/en/arcobjects/latest/net/webframe.htm#WalthroughBuildingCustomUIElementsUsingAdd-Ins.htm)
* [Walkthrough2 - Building editor extensions using add-ins (ArcObjects .NET 10.8 SDK)](https://desktop.arcgis.com/en/arcobjects/latest/net/webframe.htm#WalkthroughBuildingEditorExtensionsUsingAdd-Ins.htm)

Data used for testing came from the following link:
* [United States Census Bureau](https://www.census.gov/geographies/mapping-files.html)

Here is a link to the ESRI ArcGIS Pro SDK Community Samples Github: 
* [ArcGIS Pro 2.8 SDK for .NET - Community Samples](https://github.com/Esri/arcgis-pro-sdk-community-samples)

**Note: The ArcGIS Pro 2.8 SDK is different from ArcObjects SDK (.NET) 10.6. Both have different requirements. Consult the developer documentation provided by ESRI to use the ArcGIS Pro 2.8 SDK. Click [here](https://pro.arcgis.com/en/pro-app/latest/sdk/) to link to the documentation for ArcGIS Pro 2.8 SDK. (Credentials to view documentation may be required.)**

## Licensing
Copyright 2021 galacticgerbil

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

**Note: For a stand-alone licence, download the License.txt file.**
