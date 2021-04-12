---
# Mandatory fields.
title: translate_strings       # (Required) Very important for SEO.
description: How to translate strings # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: howto               # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Translate strings

Translate strings from resource ID to translated value using the DCF globalization utility.

## Config

The **Resource Manager** handles reading the resource strings from various sources. The sources are specified in the config file:

```XML
<SuperOffice>
  ...
  <Client>
    <Application name="WebClient" instance="Web" />
    <Globalization>
      <ResourceProviders>
        <add name="DllFile" rank="20" assemblyname="SuperOffice.DCF" objecttype="SuperOffice.Globalization.ResourceDllProvider" params="SuperOffice.Web.Globalization.ResourceStrings;SuperOffice.Web.Globalization" />
        <add name="FieldLabelFromDB" rank="10" assemblyname="SuperOffice.DCF" objecttype="SuperOffice.Globalization.FieldLabelProvider" />
        <add name="ResxFile" rank="30" assemblyname="SuperOffice.DCF" objecttype="SuperOffice.Globalization.ResXmlFileProvider" params=".\TestXmlResources" />
      </ResourceProviders>
    </Globalization>
  </Client>
</SuperOffice>
```

This specifies that the ResourceManager should first load the `FieldLabel` provider, which reads from the database.

Next, the resource DLL **SuperOffice.Web.Globalization** is loaded using the `ResourceDllProvider`, and the strings in the bundle `SuperOffice.Web.Globalization.ResourceStrings` are read in.

Finally, the XML text file *TestXmlResources.resx* is loaded using the `ResXml` file provider.

## Resx file

```XML
<?xml version="1.0" encoding="utf-8"?>
<root>
<!-- Microsoft ResX Schema -->
  <data name="SR_FOOBAR">
    <value>This is funked up beyond all recognition.</value>
  </data>
</root>
```

## Translate

Assuming the resource file contains a string ID `SR_FOOBAR`, then the program can get the translated value using:

```csharp
string resid = "SR_FOOBAR";
string res_out = SuperOffice.Globalization.ResourceManager.GetString(resid);
Console.Out.WriteLine("{0}={1}", resid, res_out);
```

> [!NOTE]
> The resource manager also handles resource names that are decorated with square brackets for you. This is the same as the above:

```csharp
string resid = "[SR_FOOBAR]";
string res_out = SuperOffice.Globalization.ResourceManager.GetString(resid);
Console.Out.WriteLine("{0}={1}", resid, res_out);
```
