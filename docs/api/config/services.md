---
title: Services element
uid: ns_config_services
description: NetServer Services element
so.date: 12.09.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, Services, web services, ApplicationToken, DefaultMode, RemoteBaseURL, SwitchDefault, SwitchFailover
so.topic: reference
so.envir: onsite
---

# NetServer Services element

Configuration settings used to manage SuperOffice web services. It specifies whether an application is working locally or remotely.

```XML
<Services>
  <add key="DefaultMode" value="Local" />
  <add key="SwitchDefault" value="Remote" />
  <add key="SwitchFailover" value="60" />
  <add key="RemoteBaseURL" value="http://localhost/remote/services88/" />
  <add key="ApplicationToken" value="" />
</Services>
```

| Name | Description | Default |
|---|---|---|
| ApplicationToken | Application token passed with services to identify the client application. | |
| DefaultMode | Mode used for Service calls. Options are Local or Remote. | Local |
| RemoteBaseURL | Base URL and file name for remote web services (SuperOffice.Services.Stub). This value will be overridden by `WebServices.RemoteBaseURL`. | `http://localhost/webs/SuperOffice.Web.Services` |
| SwitchDefault | Default mode for the switch. | Remote |
| SwitchFailover | Timeout before failover in seconds. | 60. |

**Switch mode**, when set, will attempt to communicate with the setting defined in Services-SwitchDefault. If unable to communicate successfully, NetServer will switch to the other setting option (Local or Remote) and attempt to communicate again.

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.Services>
