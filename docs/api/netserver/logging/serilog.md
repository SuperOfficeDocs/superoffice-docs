---
uid: logging_serilog
title: SuperOffice.Serilog
author: xt1
so.date: 2021-05-07
keywords: logging
so.topic: concept
---

# SuperOffice.Serilog

The benefit of using the [ILogger][1] framework is that other systems can be plugged in, to allow logs to flow to lots of other places than just a text file. The log source (NetServer) is decoupled from the log sinks (text files, databases, cloud services).

[Serilog][2] is one of several logging frameworks that support the general **ILogger** API.

The **SuperOffice.Serilog.dll** is a thin wrapper around the Serilog logger. The wrapper handles setup and configuration.

```cs
public ILoggerProvider CreateLoggerProvider()
{
  string serilogConfig = FindSerilogConfigFile("serilog.json");
  serilogConfig = serilogConfig ?? FindSerilogConfigFile("appsettings.json");
  if (File.Exists(serilogConfig))
    return CreateLogProviderFromConfigFile(serilogConfig);
  return null;
}
```

1. It looks for a *serilog.json* file in the current and parent directories.
2. If nothing is found, then it looks for an *appsettings.json* file.
3. If no config file is found, then we don't use Serilog.
4. If we do find a Json config file, we can read it and set up the Serilog configuration pipeline:

```cs
ILoggerProvider CreateLogProviderFromConfigFile(string serilogConfigFilePath)
{
  var configuration = new ConfigurationBuilder()
    .SetBasePath(Path.GetDirectoryName(serilogConfigFilePath))
    .AddJsonFile(Path.GetFileName(serilogConfigFilePath))
    .Build();
  var logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).CreateLogger();
  Log.Logger = logger;
  var provider = new SerilogLoggerProvider(logger);
  return provider;
}
```

> [!NOTE]
> You need to [create the serilog.json file][3] and restart CRM Web if you switch from standard NetServer logging to Serilog.

## Files to deploy

Don't want logging via Serilog? Remove the following DLLs:

* SuperOffice.Serilog.dll
* Serilog.dll
* Serilog.Extensions.Logging.dll
* Serilog.Settings.Configuration.dll
* Serilog.Sinks.Debug.dll
* Serilog.Sinks.File.dll

<!-- Referenced links-->
[1]: https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger
[2]: https://serilog.net/
[3]: configure-serilog.md
