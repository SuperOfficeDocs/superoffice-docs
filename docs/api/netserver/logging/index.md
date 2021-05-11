---
uid: logging_netserver
title: Logging in NetServer
author: xt1
so.date: 2021-05-07
keywords: logging
so.topic: concept
---

# Logging in NetServer

NetServer has switched from using a baked-into-the-code logger to using an extensible plugin system of [ILogger][1] based loggers.

The old logger now lives in *SuperOffice.Logging.dll* but you can remove it, replace it, or add more loggers alongside it.

All the logger plugins are used - there is no preferential treatment among the ILoggers.

For web applications, ASP.NET will load all the DLLs in the *bin* folder automatically.

For console applications, you will need to add the plugins to the `<DynamicLoad>` section or add explicit references to
make sure the DLLs are loaded and found by the class factory.

## Configuration

NetServer uses its own [Diagnostics config section][2] to determine what information to send to the ILoggers.

```xml
<Diagnostics>
  <add key="LogWarning" value="false">
</Diagnostics>
```

With the above section, your logger plugin will not see any warnings, no matter what you specify in the logger's configuration.

## Log levels

The NetServer config supports the following log levels, in descending order:

* Error
* Warning
* Information
* Debug
* Trace

These can be turned on or off individually:

```xml
<Diagnostics>
  <add key="LogError" value="true">
  <add key="LogWarning" value="false">
  <add key="LogInformation" value="false">
  <add key="LogDebug" value="true">
  <add key="LogTrace" value="false">
</Diagnostics>
```

This will log **Error** and **Debug** messages, but not Warning, Information, or Trace messages.

> [!TIP]
> You can also [filter the logs][3].

## ILoger options

* [Use the standard NetServer logger][4]
* [Use Serilog][5]
* [Create a custom logger][6]

<!-- Referenced links-->
[1]: https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger
[2]: ../config/diagnostics.md
[3]: filter-logs.md
[4]: standard-netserver-log.md
[5]: serilog.md
[6]: create-custom-logger.md
