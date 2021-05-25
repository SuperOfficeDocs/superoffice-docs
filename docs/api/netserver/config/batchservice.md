---
title: NetServer BatchService element
uid: ns_config_batch_service
description: NetServer BatchService element
so.date: 06.06.2018
author: {github-id}
keywords: config
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

| Name | Description |
|---|---|
| ServiceName | Returns the name of the service. This name is the one used to install the service under the service control manager in windows. If you want more than one of this service installed on the same machine, this setting must be unique for each service. |
| MaxTasks | Maximum number of tasks to spawn simultaneously. |
| CPUThreshold | CPU Threshold value in percentage. This value is used to check the computer's CPU load when spawning a new task. If the total CPU usage is above this value, no more tasks will be started even though max tasks has not been reached. |
| PollingInterval | Returns the number of seconds to sleep between each time the service checks for new tasks. |
| DiagnosticsWebUri | Returns the URL that the machine should bind against when starting the HTTP monitor utility that displays the current state and log in a browser. |
| ImpersonateReporterPlugin | Returns true/false if the batch service should impersonate the reporter executor with the document identity. |
| ReporterPath | Returns the path to the reporter executer file. This can be left blank to try the default paths. If the batch service is located in the default location (same location as CRM web), there should be no need to change this value. Also note that CRM web has a similar field in its configuration. This specific configuration field should only be used when CRM web and the Batch Service are located on different machines. |
| TaskTimeout | Returns the timeout in seconds for spawned tasks. -1 is infinity. |
| RunTasksInProcess | Set this property to true if batch tasks should be run in-process (as an asynchronous operation) or if it should run under the batch service.<br>Default: false |
