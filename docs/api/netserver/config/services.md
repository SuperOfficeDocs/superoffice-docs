---
title: Services element
uid: ns_config_services
description: NetServer Services element
so.date: 06.06.2018
author: {github-id}
keywords: config
so.topic: reference
so.envir: onsite
---

# NetServer Services element

Configuration settings used to manage SuperOffice web services.

```XML
<Services>
  <add key="DefaultMode" value="Local" />
  <add key="SwitchDefault" value="Remote" />
  <add key="SwitchFailover" value="60" />
  <add key="RemoteBaseURL" value="http://localhost/remote/services86/" />
  <add key="ApplicationToken" value="" />
</Services>
```

| Name | Description |
|---|---|
| DefaultMode | Mode used for Service calls. Options are Local or Remote.<br>Default: Local |
| SwitchDefault | If Default mode is unsuccessful, default mode for the switch.<br>Default: Remote |
| SwitchFailover | Timeout before failover in seconds.<br>Default: 60. |
| RemoteBaseURL | Base URL for remote web services. This value will be overridden by `WebServices.RemoteBaseURL`. <br>Default: `http://localhost/webs/SuperOffice.Web.Services` |
| ApplicationToken | Application token passed with services to identify the client application. |
