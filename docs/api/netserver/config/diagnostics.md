---
title: Diagnostics element
uid: ns_config_diagnostics
description: NetServer configuration of diagnostic logging tools.
so.date: 12.08.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, Diagnostics, log, CheckBrowserVersion, EnableResourceTracer, EnableScaffolding, EnableStackTracing, LogDebug, LogError, LogWarning, LogFolder, LoggedServices, LogInformation, LogWarning, LogTrace, LogToFile, LogToSuperOffice, LogServiceCalls, AppInsightInstrumentationKey, EnableQAAttributes, LogLongQueries, ShowExceptionsFromBackend
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

| Name | Description | Default |
|---|---|---|
| AppInsightInstrumentationKey | Identifier of resource that you want to associate your telemetry data with. | |
| CheckBrowserVersion | Determines whether browser version information be sent back to SuperOffice for compatibility verification. | |
| EnableQAAttributes | If true, the SCIL components render additional attributes to help with automated UI tests. | |
| EnableResourceTracer | Enable tracing of resource usage per operation to trace. | |
| EnableScaffolding | When this option is enabled, extra logging is performed. It is strongly recommended to have this option enabled during development and testing. Huge log files are generated when this option is enabled! Turn this off when not needed in prod.| off |
| EnableStackTracing | Should stack traces be collected by various events? | |
| LogDebug | Log debug information. This includes successful SQLs passed to the database. Only use this option while debugging. This will be a severe performance hit! | false |
| LogDebugFrom | Comma separated list of classes, namespaces to log from. Filters the debug logging. | |
| LogError | Log all error messages? | true |
| LogEventRecorder | Include a snapshot of the event recorder in all log entries. | |
| LogFailureAudit | Log failed authentications? | true |
| LogFolder | Folder (for example UNC path) where the log file is to reside. Note that the owner of the process needs to have access to manipulate files in this folder. The Documents/Impersonation settings apply! | |
| LoggedServices | List of services to be logged. If not blank, a comma-separated list of service names (without the Agent suffix, for instance: BLOB, Appointment). | Blank = all |
| LogInformation | Log general information including successful SQL passed to the database. Only use this option while debugging. This will be a performance hit! | false |
| LogInformationFrom | Comma separated list of classes, namespaces to log from. Filters the information logging. | |
| LogLongQueries | Should long-running queries be logged in textual form to a special file? | false |
| LogLongQueriesAsXML | Should long-running queries be logged to a special file (*Query_year.month.day.log*) in XML serialized format, for later analysis and reruns using the QueryWorkbench tool. | |
| LogLongQueriesToPlugins | Should long-running queries be logged to SoLoggerPlugins? | false |
| LogMail | Log mail server communication. | |
| LogMailFolder | Folder to use for mail logging. The owner of the process must have access to update files in this folder. | |
| LogServiceCalls | Should calls to the service layer be logged? | |
| LogSuccessAudit | Log successful authentications (access granted). | false |
| LogTimes | Log times to file. | |
| LogToEventLog | Log to the OS event log? (Information Level Ignored) | true |
| LogToFile | Log to a LogFile. | false |
| LogToSuperOffice | Log to SuperOffice Research and Product Development (Online through a web service). If you experience poor performance during login, set this to False. | false |
| LogToTrace | Log to a Trace that can be listened to by a `System.Diagnostics.TraceListener.Default`. | false |
| LogTrace | Log trace information. This includes a lot of information. Only use this option while debugging. This will be a severe performance hit! | false |
| LogTraceFrom | Comma separated list of classes, namespaces to log from. Filters the trace logging. | |
| LogWarning | Should warning messages be logged? | false |
| LongQueryThreshold | Threshold for logging a long-running query, in milliseconds. Queries that execute in less than this time are not logged as long-running. The time is from the moment the SQL text is sent to the database until the first row (for a select) or the 'nn rows affected' return value is received. | 2500 |
| ShowExceptionsFromBackend | If true, then the innermost exception message from the backend will be shown in the GUI, directly when the error happens. | |
| UsageStatUrl | URL for reporting Usage Statistics. | |
| UserSyncUrl | URL for synchronizing user information. | |

> [!NOTE]
> Logging is now done through [Logging plugins][1] - so there may be additional configuration needed, depending on your logging plug-in.

See the [NetServer Core reference][2] for details about handling this programmatically.

<!-- Referenced links -->
[1]: ../logging/index.md
[2]: <xref:SuperOffice.Configuration.ConfigFile.Diagnostics>
