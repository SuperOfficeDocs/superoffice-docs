---
title: Reporter element
uid: ns_config_Reporter
description: NetServer Reporter element
so.date: 12.07.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, Reporter, ExePath, ODBC, Timeout
so.topic: reference
so.envir: onsite
---

# NetServer Reporter element

Configuration values related to Reporter.

```XML
<Reporter>
  <add key="ExePath" value="bin\\Reporter" />
  <add key="Timeout" value="300000" />
  <add key="ODBC" value="SuperOffice" />
</Reporter>
```

| Name | Description | Default |
|---|---|---|
| ExePath | Contains the path to the folder where the file *SoReporterExecuter.exe* is located. | *bin\\Reporter* |
| ODBC | ODBC data-source name to use when running Reporter. | |
| Timeout | Timeout in milliseconds for the reporter process. | 300000 |

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.Reporter>
