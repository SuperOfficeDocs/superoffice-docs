---
title: Reporter element
uid: ns_config_Reporter
description: NetServer Reporter element
date: 12.07.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, Reporter, ExePath, ODBC, Timeout
content_type: reference
deployment: onsite
redirect_from: /en/api/netserver/config/reporter
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

> [!NOTE]
> Declaration is needed in the top of the web config file

```XML
<section name="Reporter" type="System.Configuration.NameValueSectionHandler, System, Version=1.0.5000.0, Culture=neutral, PublicKeyToken=b77a5c561934e089" />
```

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.Reporter>
