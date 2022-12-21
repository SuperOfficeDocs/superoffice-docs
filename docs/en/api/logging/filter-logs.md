---
uid: filter_netserver_logs
title: Logging in NetServer
description: How to filter NetServer logs.
author: xt1
so.date: 05.07.2021
keywords: logging
so.topic: howto
---

# Filtering the logs

The [NetServer config file][1] supports filtering logging to specific namespaces or classes.

```xml
<Diagnostics>
  <add key="LogWarning" value="true">
  <add key="LogWarningFrom" value="SuperOffice.Data">
</Diagnostics>
```

The above section tells the logger to only log warnings from the **SuperOffice.Data** namespace.

The **Log...From** supports both class names and namespaces.

## To log from a specific class

```xml
<Diagnostics>
  <add key="LogWarning" value="true">
  <add key="LogWarningFrom" value="SoCommand">
</Diagnostics>
```

## You can filter on multiple names

```xml
<Diagnostics>
  <add key="LogWarning" value="true">
  <add key="LogWarningFrom" value="SoCommand,SoDataReader,SuperOffice.CRM.Webhooks">
</Diagnostics>
```

<!-- Referenced links -->
[1]: ../config/diagnostics.md

<!-- Referenced images -->
