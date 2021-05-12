---
uid: logging_superoffice
title: SuperOffice.Logging
author: xt1
so.date: 2021-05-07
keywords: logging
so.topic: concept
---

# SuperOffice.Logging

This is the **standard NetServer logger**. It lives in *SuperOffice.Logging.dll*. It reads configuration from the NetServer *web.config* file's [Diagnostics section][2]

Like all logging, it is subject to filtering according to the NetServer Diagnostics settings.

```xml
<Diagnostics>
  <add key="LogError" value="true">
  <add key="LogWarning" value="true">
  <add key="LogWarningFrom" value="SoCommand,SoDataReader,SuperOffice.CRM.Webhooks">
  <add key="LogInformation" value="true">
  <add key="LogInformationFrom" value="SoCommand,SoDataReader,SuperOffice.CRM.Webhooks">
  <add key="LogDebug" value="false">
  <add key="LogDebugFrom" value="SoCommand,SoDataReader,SuperOffice.CRM.Webhooks">
  <add key="LogTrace" value="false">
  <add key="LogTraceFrom" value="SoCommand,SoDataReader,SuperOffice.CRM.Webhooks">
  <add key="LogToFile" value="true">
  <add key="LogFolder" value="C:\logs">
</Diagnostics>
```

The above section will:

* Write logs to the file *C:\logs\2021-05-07.log*.
* Write to a log file with today's date in the *LogFolder*.
* Create the *LogFolder* if it does not exist.
* Write to the log file using DocumentArchive impersonation (if configured).

> [!NOTE]
> SuperOffice.Logging will do nothing if the `Diagnostics/LogToFile` value is false.

## Files to deploy

Remove the following if you don't want logging to file:

* SuperOffice.Logging.dll

<!-- Referenced links-->
[1]: https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger
[2]: ../config/diagnostics.md
