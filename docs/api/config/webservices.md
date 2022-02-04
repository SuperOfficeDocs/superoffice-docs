---
title: WebServices element
uid: ns_config_webservices
description: NetServer WebServices element
so.date: 12.17.2021
author: Bergfrid Dias
keywords: NetServer, web.config, web services, AllowWebServiceRequests, RemoteBaseURL, RemoveInvalidXMLText, WrapExceptions
so.topic: reference
so.envir: onsite
---

# NetServer WebServices element

Configuration section used to define SuperOffice CRM web service settings.

```XML
<WebServices>
  <add key="AllowWebServiceRequests" value="true" />
  <add key="WrapExceptions" value="true" />
  <add key="RemoveInvalidXMLText" value="false" />
</WebServices>
```

| Name | Description | Default |
|---|---|---|
| AllowWebServiceRequests | Permit requests to web services. This value is supported in the default `SoWcfRequestInterceptor` and can be overridden by making a custom `SoWcfRequestInterceptorPlugin`. | true |
| RemoteBaseURL | Base URL for remote services in a multi-tenant environment. Use this setting instead of `Services.RemoteBaseURL` in CRM Online environments. Will be overridden if [Services.RemoteBaseURL][2] is set. | `http://localhost/webs/SuperOffice.Web.Services` |
| RemoveInvalidXMLText | If we should remove UTF-8 characters that are not valid XML. The Text table is the only place where this filter is active. | |
| WrapExceptions | Check if NetServer shall wrap and serialize exceptions, or leave it up to the communication carrier (WCF). | |

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.WebServices>
[2]: services.md
