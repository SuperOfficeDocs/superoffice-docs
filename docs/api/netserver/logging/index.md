---
uid: logging-netserver
title: Logging in NetServer
author: xt1
so.date: 2021-05-07
keywords: logging
so.topic: concept
---


NetServer has switched from using a baked-into-the-code logger to using an extensible plugin system of [ILogger][1] based loggers.

The old logger now lives in `SuperOffice.Logging.dll` but you can remove it, replace it, or add more loggers alongside it.

All the logger plugins are used - there is no preferential treatment among the ILoggers.

For web applications, ASP.net will load all the DLLs in the `bin` folder automatically.

For console applications, you will need to add the plugins to the `<DynamicLoad>` section or add explicit references to
make sure the DLLs are loaded and found by the class-factory.

## Configuration

NetServer uses its own [Diagnostics config section][2] to determine what information to send to the ILoggers. 

In other words, if your config file says

```xml
   <Diagnostics>
     <add key="LogWarning" value="false">
   </Diagnostics>
```

then your logger plugin will not see any warnings, no matter what you specify in the logger's configuration.

## Filtering the logs

The NetServer config file supports filtering logging to specific namespaces or classes.

```xml
   <Diagnostics>
     <add key="LogWarning" value="true">
     <add key="LogWarningFrom" value="SuperOffice.Data">
   </Diagnostics>
```

tells the logger to only log warnings from the *SuperOffice.Data* namespace.

The log...from supports class names and namespaces.

To log from a specific class:

```xml
   <Diagnostics>
     <add key="LogWarning" value="true">
     <add key="LogWarningFrom" value="SoCommand">
   </Diagnostics>
```

You can filter on multiple names:

```xml
   <Diagnostics>
     <add key="LogWarning" value="true">
     <add key="LogWarningFrom" value="SoCommand,SoDataReader,SuperOffice.CRM.Webhooks">
   </Diagnostics>
```


[1]: https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger
[2]: ../config/diagnostics.md
