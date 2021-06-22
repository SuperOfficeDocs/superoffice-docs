---
title: WebApi element
uid: ns_config_webapi
description: NetServer WebApi element
so.date: 06.06.2018
author: {github-id}
keywords: config, NetServer, authentication, WebAPI
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

| Name | Default | Description |
|---|---|
| AuthorizeWithUsername | true | Allow WebAPI to authorize with username + password. |
| AuthorizeWithTicket | true | Allow WebAPI to authorize with session tickets. |
| AuthorizeWithImplicit | true | Allow WebAPI to authorize with implicit identity from IIS.|
| CORSEnable | false | Allow 3rd party web pages to call WebAPI from the browser.|
| CORSOrigin | | If CORS is enabled, define space-delimited Origins that are allowed to call the WebAPI from the browser. Example value: `"http://foo.bar http://localhost/ http://localhost *"`. |
