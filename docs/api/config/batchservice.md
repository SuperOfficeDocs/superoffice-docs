---
title: NetServer BatchService element
uid: ns_config_batch_service
description: NetServer BatchService element. Configuration values for the Windows batch task service.
so.date: 12.17.2021
author: Bergfrid Dias
keywords: NetServer, web.config, BatchService, DiagnosticsWebUri
so.topic: reference
so.envir: onsite
so.client: win
---

# NetServer BatchService element

Configuration values for the Windows batch task service (`SoBatchService`).

```XML
<BatchService>
  <add key="ServiceName" value="SuperOffice Batch Service" />
  <add key="MaxTasks" value="16" />
  <add key="CPUThreshold" value="100" />
  <add key="PollingInterval" value="2" />
  <add key="DiagnosticsWebUri" value="http://localhost:8002/" />
  <add key="RunTasksInProcess" value="true" />
</BatchService>
```

| Name | Description | Default |
|---|---|---|
| CPUThreshold | CPU threshold value in percentage. Used to check the computer's CPU load when spawning a new task. If the total CPU usage is above this value, no more tasks will be started even though max tasks has not been reached. | 100 |
| DiagnosticsWebUri | The URL that the machine should bind against when starting the HTTP monitor utility that displays the current state and log in a browser. | `http://localhost:8002` |
| ImpersonateReporterPlugin | Should the batch service impersonate the reporter executor with the document identity? True/false. | |
| MaxTasks | The maximum number of tasks to spawn simultaneously. | 16 |
| PollingInterval | The number of seconds to sleep between each time the service checks for new tasks. | 2 |
| ReporterPath | The path to the reporter executer file. Can be left blank to try the default paths. If the batch service is located in the default location (same location as CRM web), there should be no need to change this value.<br />Also, note that CRM web has a similar field in its configuration. This specific configuration field should only be used when CRM web and the Batch Service are located on different machines. | |
| RunTasksInProcess | Set this property to true if batch tasks should be run in-process (as an asynchronous operation) or if it should run under the batch service. | false |
| ServiceName | The name of the service. This name is the one used to install the service under the service control manager in Windows. If you want more than one service installed on the same machine, this setting must be unique for each service. | SuperOffice Batch Service |
| TaskTimeout | The timeout in seconds for spawned tasks. -1 is infinity. | |

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.BatchService>
