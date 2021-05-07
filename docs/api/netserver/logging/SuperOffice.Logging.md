---
uid: logging-superoffice
title: SuperOffice.Logging
author: xt1
so.date: 2021-05-07
keywords: logging
so.topic: concept
---

This is the standard NetServer logger. It lives in `SuperOffice.Logging.dll`. It reads configuration from the NetServer web.config file's [Diagnostics section][2]

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

This will write logs to the file `C:\logs\2021-05-07.log`

## SuperOffice.Logging

Does nothing if the `Diagnostics/LogToFile` value is false.

Writes to a logfile with today's date in the `LogFolder`.
Will create the LogFolder if it does not exist.

Writes to the logfile using DocumentArchive impersonation (if configured).

## Files to deploy

Remove the following if you don't want logging to file:

* SuperOffice.Logging.dll


[1]: https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger
[2]: ../config/diagnostics.md
