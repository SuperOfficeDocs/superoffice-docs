---
title: WebServices element
uid: ns_config_webservices
description: NetServer WebServices element
so.date: 06.06.2018
author: {github-id}
keywords: config
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

| Name | Description |
|---|---|
| AllowWebServiceRequests | Permit requests to web services. This value is supported in the default `SoWcfRequestInterceptor` and can be overridden by making a custom `SoWcfRequestInterceptorPlugin`. |
| WrapExceptions | Check if NetServer shall wrap and serialize exceptions, or leave it up to the communication carrier (WCF). |
| RemoveInvalidXMLText | If we should remove UTF-8 characters that are not valid XML. The Text table is the only place where this filter is active. |
| RemoteBaseURL | Base URL for remote services. Will overridden by `Services.RemoteBaseURL`.<br>Default: `http://localhost/webs/SuperOffice.Web.Services` |
