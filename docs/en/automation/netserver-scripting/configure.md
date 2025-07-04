---
title: How to configure scripting
uid: concfig_scripting_ns_services
description: How to configure scripting
author: Tony Yates
date: 04.15.2009
content_type: howto
keywords:
deployment: onsite
platform: web
---

# How to configure scripting

When installing SuperOffice CRM Web, a new scripting section is added to the web applications *web.config* file. If upgrading from a previous version, optionally run the *SoAppConfig.exe* configuration utility.

**SoAppConfig.exe utility with the Scripting section displayed:**

![setup -screenshot][img1]

The configuration options are:

* Enabling scripting overall.
* The path to the folder where the scripts are stored. If no path is set, the \[ArchivePath\]\\scripts is used.
* The timeout limit is how much time is allowed on synchronous scripts. Asynchronous scripts are not affected by the limit.
* The Script violation limit is the number of times a script can violate the time limit before being disabled.

The *SoAppConfig.exe* utility sets the [Scripting section][1] of the NetServer configuration.

## Document section

One more important configuration section is the documents section. The reason for this is that each script runs in a separate appdomain than NetServer services, and the scripting app domain dynamically creates a separate configuration file for that appdomain. This temporary configuration file, named *webScriptEngine.config*, is saved and read from the Document's `TemporaryPath` value. Make sure this path exists and that document permission settings are correct to read and write from this location.

```xml
<Documents\>
  ...
  <addkey\="TemporaryPath"value\="C:\\Temp" />
</Documents\>
```

<!-- Referenced links -->
[1]: ../../api/config/scripting.md

<!-- Referenced images -->
[img1]: media/scriptingsetup.png
