---
title: ns_config_Reporter
description: NetServer Reporter element
so.date: 06.06.2018
author: {github-id}
keywords: config
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

| Name | Description |
|---|---|
| ExePath | Contains the path to the folder where the file *SoReporterExecuter.exe* is located.<br>Default: *bin\\Reporter* |
| Timeout | Timeout in milliseconds for the reporter process.<br>Default: 300000 |
| ODBC | ODBC data-source name to use when running Reporter. |
