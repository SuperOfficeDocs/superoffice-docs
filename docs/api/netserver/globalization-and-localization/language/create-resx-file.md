---
title: Create our own resx file
uid: create_resx_file
description: Create our own resx file
author: {github-id}
so.date:
keywords:
so.topic: howto
# so.envir:
# so.client:
---

# Create our own resx file

SuperOffice contains resx files for each language based on the default resx file. For example, if the default resx file is *ResourceStrings.resx* the translation of this in French would be stored as *ResourceStrings.fr.resx*, "fr" is the abbreviation of the language.

To override the stock resx files, we can create our own resx file and by using the ResXmlFileProvider we can call our own strings.

To use our resx file we need to make a minor modification - adding the ResXmlFileProvider - to the config file:

```XML
<Client>
  <Application name="WebClient" instance="Web" />
  <Globalization>
    <ResourceProviders>
      <!-- Other providers used by the client -->
      <!-- ResXmlFileProvider which is used to call string that are available through resx files-->
      <add name="ResXmlFileProvider" rank="25" assemblyname="SuperOffice.DCF" objecttype="SuperOffice.Globalization.ResXmlFileProvider" params="NewResourceStrings" />
    </ResourceProviders>
  </Globalization>
</Client>
```

In the `ResXmlFileProvider` tag, params refer to the name of the resx file that contains our strings.

The next step is to create a resx file containing our own strings. Here we have created a resx file for the default language.

In the Visuals Studio development environment, we can create a new resx file and add our custom string.

![01][img1]

The inserted string can be seen in XML as below.

```XML
<?xml version="1.0" encoding="utf-8"?>
<root> 
  <xsd:schema id="root" xmlns="" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:msdata="urn:schemas-microsoft-com:xml-msdata"> <!--Some other Code--> </xsd:schema>
  <resheader name="resmimetype"> <!--Some other Code--></resheader>
  <resheader name="version"> <!--Some other Code--></resheader>
  <resheader name="reader"> <!--Some other Code--></resheader>
  <resheader name="writer"> <!--Some other Code--></resheader>
  <!--Our custom String-->
  <data name="customString" xml:space="preserve">
    <value>Navigator Panel</value>
  </data>
</root>
```

The file above is saved as *NewResourceStrings.resx*, the default resources which are used if no translation can be found.

> [!NOTE]
> The file name *NewResourceStrings* is used in the *web.config* file as a parameter to the `ResXmlFileProvider` component.

The *NewResourceStrings.no.resx* file for the Norwegian translation looks like this:

```XML
<?xml version="1.0" encoding="utf-8"?>
<root> 
  <xsd:schema id="root" xmlns="" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:msdata="urn:schemas-microsoft-com:xml-msdata"> <!--Some other Code--> </xsd:schema>
  <resheader name="resmimetype"> <!--Some other Code--></resheader>
  <resheader name="version"> <!--Some other Code--></resheader>
  <resheader name="reader"> <!--Some other Code--></resheader>
  <resheader name="writer"> <!--Some other Code--></resheader>
  <!--Our custom String-->
  <data name="customString" xml:space="preserve">
    <value>Navigasjonspanel</value>
  </data>
</root>
```

When we need to use our custom string in the SIX.web page config, we need to call it by the "name" (customString):

```XML
<control id="myLabel" type="SoLabel" context-style="Heading" width="100%">
  <caption>[customString]</caption>
</control>
```

The above code segment has been included inside the *SoNavigatorPanels.config* file’s controls tag. Once the file has been saved our custom String can be seen.

![02][img2]

<!-- Referenced images -->
[img1]: media/image001.jpg
[img2]: media/image002.jpg
