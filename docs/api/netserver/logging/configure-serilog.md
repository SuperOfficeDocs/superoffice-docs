---
uid: configure_serilog
title: Configure Serilog
author: xt1
so.date: 05.07.2021
keywords: logging
so.topic: howto
---

# Configure Serilog

To get [Serilog][5] to write to a log file, we need to create a *serilog.json* file as [described for the Serilog Configuration module][3].

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

To turn off Serilog, you need to [remove the Serilog DLLs][5].

## Sinks

We are using the **File** sink to write logs to a file. If we restart CRM Web so it reloads the logging config, we should see log output appear in the log file *C:/Logs/serilog-20210517.txt*:

```serilog
2021-05-07 17:13:11.362 +02:00 [INF] Startup: Default transaction: true through config file SuperOffice 9.9 Dev NetServer 9.9 Release (Build: 7796.SOS4MK1355) 9.9.0.14337 9.9.7796.1040 7796.SOS4MK1355 Default SOS4MK1355 NetServer
2021-05-07 17:13:11.405 +02:00 [DBG] SQL Command /* Default | - (0) |  |  */SELECT T0."prefkey", T0."prefvalue" FROM  crm7."USERPREFERENCE" T0  WHERE (T0."prefsection" = @P0) AND(T0."deflevel" = @P1)
```

> [!TIP]
> You can add [other sinks][4] to send logging information to other places, like Azure Application Insights, Elmah, DataDog, or Splunk.

<!-- Referenced links-->
[1]: https://docs.microsoft.com/en-us/dotnet/api/microsoft.extensions.logging.ilogger
[2]: https://serilog.net/
[3]: https://github.com/serilog/serilog-settings-configuration
[4]: https://github.com/serilog/serilog/wiki/Provided-Sinks
[5]: serilog.md
