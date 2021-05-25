---
title: WebApi element
uid: ns_config_webapi
description: NetServer WebApi element
so.date: 06.06.2018
author: {github-id}
keywords: config
so.topic: reference
so.envir: onsite
---

# NetServer WebApi element

Configuration values related to the WebApi web services.

```XML
<WebApi>
  <add key="AuthorizeWithUsername" value="true" />
  <add key="AuthorizeWithTicket" value="true" />
  <add key="AuthorizeWithImplicit" value="false" />
  <add key="CORSEnable" value="true" />
  <add key="CORSOrigin" value="http://foo.bar http://localhost/ http://localhost *" />
</WebApi>
```

| Name | Description |
|---|---|
| AuthorizeWithUsername | Allow WebAPI to authorize with username + password.<br>Default: true |
| AuthorizeWithTicket | Allow WebAPI to authorize with session tickets.<br>Default: true |
| AuthorizeWithImplicit | Allow WebAPI to authorize with implicit identity from IIS.<br>Default: true |
| CORSEnable | Allow 3rd party web pages to call WebAPI from the browser.<br>Default: false |
| CORSOrigin | If CORS is enabled, define space-delimited Origins that are allowed to call the WebAPI from the browser. No default is set. Example value: `"http://foo.bar http://localhost/ http://localhost *"`. |
