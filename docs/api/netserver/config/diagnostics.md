---
title: ns_config_diagnostics
description: NetServer Diagnostics element
so.date: 06.06.2018
author: {github-id}
keywords: config
so.topic: reference
so.envir: onsite
---

# NetServer Diagnostics element

Configuration of diagnostic logging tools.

```XML
<Diagnostics>
  <add key="LogError" value="true" />
  <add key="LogWarning" value="false" />
  <add key="LogInformation" value="false" />
  <add key="LogFailureAudit" value="false" />
  <add key="LogSuccessAudit" value="false" />
  <add key="LogToEventLog" value="false" />
  <add key="LogToSuperOffice" value="false" />
  <add key="LogToFile" value="true" />
  <add key="LogToTrace" value="false" />
  <add key="EnableScaffolding" value="false" />
  <add key="LogFolder" value="c:\temp\" />
  <add key="LogLongQueries" value="false" />
  <add key="LongQueryThreshold" value="5000" />
  <add key="LogServiceCalls" value="false" />
  <add key="LoggedServices" value="" />
  <add key="LogMail" value="false" />
  <add key="LogMailFolder" value="c:\temp\" />
  <add key="LogLongQueriesAsXml" value="false" />
</Diagnostics>
```

| Name | Description |
|---|---|
| LogError | Determines whether error messages are logged.<br>Default: true |
| LogWarning | Determines whether warning messages are logged.<br>Default: false |
| LogInformation | Log general information. Only use this option while debugging. This will be a performance hit!<br>Default: false |
| LogInformationFrom | Comma separated list of classes, namespaces to log from. Filters the information logging. |
| LogDebug | Log debug information. This includes successful SQLs passed to the database. Only use this option while debugging. This will be a severe performance hit!<br>Default: false |
| LogDebugFrom | Comma separated list of classes, namespaces to log from. Filters the debug logging. |
| LogTrace | Log trace information. This includes a lot of information. Only use  this option while debugging. This will be a severe performance hit!<br>Default: false |
| LogTraceFrom | Comma separated list of classes, namespaces to log from. Filters the trace logging. |
| LogFailureAudit | Log failed authentications.<br>Default: true |
| LogSuccessAudit | Log successful authentications.<br>Default: false |
| LogToEventLog | Log to the OS event log.<br>Default: true |
| LogToSuperOffice | Log to SuperOffice Research and Product Development (Online through a web service).<br>Default: false |
| SuperOfficeErrorServiceUrl | The URL used to log to SuperOffice Research and Product Development (Online through a web service). |
| LogToFile | Log to a LogFile.<br>Default: false |
| LogToTrace | Log to a Trace that can be listened to by a `System.Diagnostics.TraceListener.Default` value is false. |
| LogFolder | Folder (e.g. UNC path) where the log file is to reside. Note that the owner of the process needs to have access to manipulate files in this folder. The Documents/Impersonation settings apply! |
| EnableScaffolding | When this option is enabled, extra logging is performed. It is strongly recommended to have this option enabled during development and testing. Huge log files are generated when this option is enabled! |
| LogLongQueries | Should long-running queries be logged in textual form to a special file.<br>Default: false |
| LongQueryThreshold | Threshold for logging a long-running query, in milliseconds. Queries that execute in less than this time are not logged as long-running. The time is from the moment the SQL text is sent to the database until the first row (for a select) or the 'nn rows affected' return value is received.<br>Default:  2500 |
| LogLongQueriesAsXML | Should long-running queries be logged to a special file (Query_year.month.day.log) in XML serialized format, for later analysis and reruns using the QueryWorkbench tool. |
| EnableStackTracing | Determines whether stack traces be collected by various events. |
| CheckBrowserVersion | Determines whether browser version information be sent back to SuperOffice for compatibility verification. |
| LogServiceCalls | Determines whether calls to the service layer are logged. |
| LoggedServices | List of services to be logged; default blank means all, otherwise a comma-separated list of service names (without the Agent suffix, for instance: BLOB, Appointment). |
| LogMail | Log mail server communication. |
| LogMailFolder | Folder to use for mail logging. |
| LogTimes | Log times to file. |
| LogEventRecorder | Include a snapshot of the event recorder in all log entries. |
| EnableResourceTracer | Enable tracing of resource usage per operation to trace. |
| UsageStatUrl | URL for reporting Usage Statistics. |
| UserSyncUrl | URL for synchronizing user information. |

Logging is now done through [Logging plugins][1] - so there may be additional configuration needed, depending on your logging plug-in.

[1]: ../logging/index.md