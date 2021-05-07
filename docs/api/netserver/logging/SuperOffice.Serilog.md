---
uid: logging      
title: SuperOffice.Serilog
author: xt1
so.date: 2021-05-07
keywords: logging
so.topic: concept
---


The benefit of using the [ILogger][1] framework is that other systems can be plugged in, to allow logs to flow to lots of other places than just a text file.

The log source (NetServer) is decoupled from the log sinks (text files, databases, cloude services).

## Serilog

[Serilog][2] is one of several logging frameworks that support the general `ILogger` API.

The **SuperOffice.Serilog.dll** is a thin wrapper around the Serilog logger. The wrapper handles setup and configuration.

It looks for a `serilog.json` file in the current and parent directories. If nothing is found, then it looks for an `appsettings.json` file. If no config file is found, then we don't use Serilog.

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

if we do find a json config file, we can read it and set up the Serilog configuration pipeline.

```cs
    ILoggerProvider CreateLogProviderFromConfigFile(string serilogConfigFilePath)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Path.GetDirectoryName(serilogConfigFilePath))
            .AddJsonFile(Path.GetFileName(serilogConfigFilePath))
            .Build();
        var logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration)
            .CreateLogger();
        Log.Logger = logger;
        var provider = new SerilogLoggerProvider(logger);
        return provider;
    }
```

## Files to deploy

Remove the following if you don't want logging via Serilog:

* SuperOffice.Serilog.dll
* Serilog.dll
* Serilog.Extensions.Logging.dll
* Serilog.Settings.Configuration.dll
* Serilog.Sinks.Debug.dll
* Serilog.Sinks.File.dll

## Configuring Serilog

To get Serilog to write to a log file, we need to make a `serilog.json` file as [described for the Serilog Configuration module][3]

```json
{
  "Serilog": {
    "Using":  [ "Serilog.Sinks.File" ],
    "MinimumLevel": "Debug",
    "WriteTo": [
      { "Name": "File", "Args": { 
        "path": "C:/Logs/serilog.txt", "rollingInterval": "Day" 
      } }
    ]
  }
}
```

We are using the File sink to write logs to a file.

If we restart CRM-web so it reloads the logging config, we should see log output appear in the logfile: `C:/Logs/serilog-20210517.txt`

```serilog
2021-05-07 17:13:11.362 +02:00 [INF] Startup: Default transaction: true through config file SuperOffice 9.9 Dev NetServer 9.9 Release (Build: 7796.SOS4MK1355) 9.9.0.14337 9.9.7796.1040 7796.SOS4MK1355 Default SOS4MK1355 NetServer
2021-05-07 17:13:11.405 +02:00 [DBG] SQL Command /* Default | - (0) |  |  */SELECT T0."prefkey", T0."prefvalue" FROM  crm7."USERPREFERENCE" T0  WHERE (T0."prefsection" = @P0) AND(T0."deflevel" = @P1)
```

You can add [other sinks][4] to send logging information to other places, like Azure Application Insights, Elmah, DataDog, or Splunk.

[1]: https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger
[2]: https://serilog.net/
[3]: https://github.com/serilog/serilog-settings-configuration
[4]: https://github.com/serilog/serilog/wiki/Provided-Sinks
