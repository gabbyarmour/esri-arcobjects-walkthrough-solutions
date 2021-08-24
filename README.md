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
Here is how to use my solutions:
1. Create an Add-In Project by following the instructions of the [first walkthrough](https://desktop.arcgis.com/en/arcobjects/latest/net/webframe.htm#WalthroughBuildingCustomUIElementsUsingAdd-Ins.htm)
2. Copy/Paste CS code provided into files generated by following the walkthrough
3. Build solution solution in Visual Studio 2017
4. Click Start (Debugging) in Visual Studio 2017 to open ArcMap 10.6

**Note: Use the walkthrough instructions to build and to debug your own add-in. The troubleshooting section will provide some help.**

## Troubleshooting 
The following are examples of some troubleshooting that was done while working through these walkthroughs:

* ArcObjects Snippets have to be copied to another folder to be added for usage in the Code Snippets Manager inside of Visual Studio 2017:

  - Copy the ArcObjects Snippet folder (Common Path: C:\Program Files (x86)\ArcGIS\DeveloperKit10.6\Snippets\CSharp\):
  <p align="left">
  <img src="https://github.com/gabbyarmour/esri-arcobjects-walkthrough-solutions/blob/main/Img/FolderToCopy.png"> 
  </p>
  
  - Paste and Rename the ArcObjects Snippet folder (Common Path: C:\Program Files (x86)\ArcGIS\DeveloperKit10.6\Snippets\):
  <p align="left">
  <img src="https://github.com/gabbyarmour/esri-arcobjects-walkthrough-solutions/blob/main/Img/RenamedCopiedArcObjects.png">
  </p>
  
  - Open the Code Snippet Manager inside of Visual Studio 2017 (Tools > Code Snippet Manager):
  <p align="left">
  <img src="https://github.com/gabbyarmour/esri-arcobjects-walkthrough-solutions/blob/main/Img/CodeSnippetManager.png">
  </p>
  
  - Locate the Add button inside of the Code Snippet Manager to add the new ArcObjects Folder (ArcObjectsCS):
  <p align="left">
  <img src="https://github.com/gabbyarmour/esri-arcobjects-walkthrough-solutions/blob/main/Img/AddCodeSnippetManager.png">
  </p>
  
  - Add the new ArcObjects Folder (ArcObjectsCS) and click OK:
  <p align="left">
  <img src="https://github.com/gabbyarmour/esri-arcobjects-walkthrough-solutions/blob/main/Img/AddArcObjectsCS.png">
  <img src="https://github.com/gabbyarmour/esri-arcobjects-walkthrough-solutions/blob/main/Img/OKAddCodeSnippetManager.png">
  </p>
  
  - Right-click inside of the code (CS file) to starting using the Insert Snippet option when prompted by the walkthroughs:
  <p align="left">
  <img src="https://github.com/gabbyarmour/esri-arcobjects-walkthrough-solutions/blob/main/Img/InsertSnippetAsSuggested.png">
  </p>
   
   
* ArcGIS provides PIAs (Primary Interop Assemblies). When adding an ArcGIS reference to an add-in solution, the 'Embed Interop Types' must be set to false.

  - [Link](https://gis.stackexchange.com/questions/298043/setting-embed-interop-types-in-arcobjects-to-true-or-false) to explanation.

  - Screenshots of how to access reference properties:
  <p align="left">
  <img src="https://github.com/gabbyarmour/esri-arcobjects-walkthrough-solutions/blob/main/Img/EnterReferenceProperties.png">
  <img src="https://github.com/gabbyarmour/esri-arcobjects-walkthrough-solutions/blob/main/Img/SetToFalse.png">
  </p>


* When configuring the solution, the debug external program may need to be reset to point to the appropriate version of ArcMap.exe.

  - [Link](https://desktop.arcgis.com/en/arcobjects/latest/net/webframe.htm#HowtoDebugAdd-Ins.htm) to explanation.
  <!-- Add Screenshot Explanation -->

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
