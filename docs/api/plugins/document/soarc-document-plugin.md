---
title: How to create a managed document plugin
uid: soarc_document_plugin
description: How to create a managed document plugin
author: Tony Yates
so.date: 06.03.2006
keywords:
so.topic: howto
so.envir: onsite
# so.client:
---

# How to create a managed document plugin

## Introduction

Recently a partner, experimenting with creating a managed document plug-in, discovered that it was not nearly as simple to create a .net document plugin for SuperOffice, as it is with the default VB6 sample application, **SoDocPluginSoArc**. In this article, I would like to describe and demonstrate the steps necessary to get a .NET SuperOffice document plugin assembly working. Essentially, the steps required are listed in the following ten-step process.

1. Use *SN.exe* to create two new KeyPair files. You'll use these for creating strong name assemblies - one for the Type Library DLL, and one for the document plugin (or you can choose to use the same SNK file for both).
2. Copy *DocumentInterface.tlb* from the ClientSDK to a known directory.
3. Using *DocumentInterface.tlb*, use TLBIMP to generate a managed, signed assembly that contains the `IDocumentInterface` type.
4. Reference the assembly in your document plugin project.
5. Implement the methods of `IDocumentInterface`.
6. Copy both the managed reference `IDocumentInterface` assembly and your document plugin to the SuperOffice directory.
7. Place your document plugin and reference managed `IDocumentInterface` assembly, in the GAC (Drag and drop or use GACUTIL). As an alternative, skip this step and use the RegAsm /codebase switch in step eight to hard-code the assembly path (See *InstallDocPlugin.bat*). (Not recommended for deployment scenarios, only in testing).
8. Use REGASM to register the document plugin, as well as create a type library file for your document plugin, and register it. As an alternative to step 7, use the RegAsm /codebase switch to hard-code the assembly path (See *InstallDocPlugin.bat*).
9. Append a Module section in the *SoLoader.ini* file (located in the Client directory, for example, *C:\\SuperOffice\\Client*) and the filename of your document plugin under the \[Files\] section.
10. Start SuperOffice and select the document archive plugin from the **Preferences\\System** options.

## The Preliminaries

Start by creating a strong name key file that will be used to sign the assembly that will contain the `IDocumentInterface` definition, as well as your document plug-in assembly. As seen below, open a Visual Studio Command Prompt and use the SN.exe utility to generate the keypair file.

![x -screenshot][img1]

Next, you will need a managed version of the `IDocumentInterface` declaration to reference in the document plugin. Using the *DocumentInterface.tlb* and the keyfile you just generated, use the *TLBIMP.exe* utility to generate a managed assembly that contains the `IDocumentInterface` definition. See code below. Do not forget the /keyfile:yourKeyFile.snk switch, as both this assembly and the document plugin, require a strong name.

Now you should have a strong name key file to sign your document plugin assembly, as well as the signed assembly that contains the `IDocumentInterface` definition. Now it is time to create the solution.

![x -screenshot][img2]

## The Solution

Create a new class library solution and name it in accordance with the SuperOffice naming scheme for document plugins, for example, SoDocPlugin_YourPluginName. When the class library project is created, create a reference to the assembly that contains the IDocumentInterface, see below. Rename the default class to something you like, for example, `MyDocumentPlugIn`.

![x -screenshot][img3]

Since this assembly is being consumed in a COM environment, it will need to be visible in that COM environment. To make this happen, a few things first need to be set. This includes making the class COM Visible, assigning the class a GUID value, as well as setting the class interface type. Using VB.NET in VS 2005, this is all done for you if you are creating a COMClass library when first creating the solution. However, in C#, this is accomplished by decorating the class declaration with the appropriate attributes. As seen below, these include COMVisible, GUID, and ClassInterface. Optionally, you can also set these values in the project properties>AssemblyInformation window.

![x -screenshot][img4]

Next, you must implement each method defined in the `IDocumentInterface` in accordance with guidelines specified in the Client SDK (Reference > Plugin Systems > Document Plugin API).

The most crucial method in the interface is `GetPlugInProperty`. When SuperOffice starts, the method is called and the `pluginId` value is requested. If the value returned is not unique, an error will be displayed telling you two plugins have the same id and then the offending document plugin will not be loaded.

When finished implementing the plugin, copy all referenced assemblies into the SuperOffice directory.

Next, your document plugin assembly, as well as the managed `IDocumentInterface` assembly, needs to be placed in the **Global Assembly Cache** (GAC). Do this by either dragging and dropping your assembly into the *WINDOWS\\assembly* directory, or using the *GACUTIL.exe* utility:

![x screenshot][img5]

For SuperOffice to discover your document plugin, SuperOffice must be able to detect the class that implements `IDocumentInterface`, and call each interface method as necessary. Since SuperOffice is not able to read a .Net assembly, you must generate a type library with the same name as your plugin (or at least starting withSoDocPlugin), which exposes this information for your assembly. To do this, use the REGASM.exe utility. Open a Visual Studio Command Prompt and generate the type library:

![x -screenshot][img6]

Finally, modify the *SoLoader.ini* file and test the plugin.

Open the *SoLoader.ini* file, found in the *SuperOffice\\Client* directory, and create a new module section:

```text
[Module:SuperOffice Plugin]
Regsvr = No
ForceRegsvr = No
NoOverWrite = No
RebootIfInUse = Yes
UpdateOnly = No
Shared = No
```

As seen in **Listing Two**, add your document plugin assembly name and module group assignment to the \[Files\] section.

```text
[Files]

; ... List Omitted For Brevity

SoDocPluginMyDocumentPlugin.dll = SuperOffice Plugin
```

Now it's time to test. Open SuperOffice and verify your plugin is listed in the Preferences > System > Default document archive list:

![x -screenshot][img7]

## Conclusion

In this article, I talked about how to create a SuperOffice Document Plugin using managed code. As you can see, creating a managed document plugin for SuperOffice is not exactly an easy task - but not impossible either.

I want to thank Jose Aparicio (Scarp) for kicking off the experimentation, and contributing the VB.NET code (See downloads above). I would also like to thank Christian Mogensen for his insight to the plugin process and hints, as well as Helene Hansen for her tireless efforts of actually stepping through the debugging process and allowing me to see the SuperOffice plugin process first hand. Good Job!

## Downloads

* [InstallDocPlugin.bat.txt](../../../assets/downloads/api/InstallDocPlugin.bat.txt)
* [SoArcDocumentPlugin.net.zip](../../../assets/downloads/api/soarcdocumentplugin.net.zip)
* [SoArcDocumentPlugin.Net(7.5).zip](../../../assets/downloads/api/soarcdocumentplugin.net-7.5.zip)
* [DocumentPlugins-WinWeb-7.5.zip](../../../assets/downloads/api/documentplugins-winweb-7.5.zip)
* [SuperOffice.TestDocPlugin-v8.zip](../../../assets/downloads/api/superoffice.testdocplugin-v8.zip)
* [SuperOffice.TestDocPlugin-v8SR3.zip (with CheckInCheckOutLocking)](../../../assets/downloads/api/superoffice.testdocplugin_withcheckincheckout.zip)

<!-- Referenced links -->

<!-- Referenced images -->
[img1]: media/a-createkeyfile.png
[img2]: media/b-createmanageddocinterface.png
[img3]: media/c-addreference.gif
[img4]: media/d-csharpclass.png
[img5]: media/e-addtogac.png
[img6]: media/f-createdocplugintlb.png
[img7]: media/g-preferences.png
