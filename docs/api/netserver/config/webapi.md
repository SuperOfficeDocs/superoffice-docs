---
title: WebApi element
uid: ns_config_webapi
description: NetServer WebApi element
so.date: 12.09.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, authentication, WebAPI, AuthorizeWithImplicit, AuthorizeWithTicket, AuthorizeWithUsername, CORSEnable, CORSOrigin, CORS, authorize, authentication, security
so.topic: reference
so.envir: onsite
---

# NetServer WebApi element

Configuration values related to the [WebAPI][2] web services.

```XML
<WebApi>
  <add key="AuthorizeWithUsername" value="true" />
  <add key="AuthorizeWithTicket" value="true" />
  <add key="AuthorizeWithImplicit" value="false" />
  <add key="CORSEnable" value="true" />
  <add key="CORSOrigin" value="http://foo.bar http://localhost/ http://localhost* https://mail.google.com" />
</WebApi>
```

| Name | Description | Default
|---|---|---|
| AuthorizeWithImplicit | Allow WebAPI to authorize with implicit identity from IIS.| true |
| AuthorizeWithTicket | Allow WebAPI to authorize with session tickets. | true |
| AuthorizeWithUsername | Allow WebAPI to authorize with username + password. | true |
| CORSEnable | Allow 3rd party web pages to call WebAPI from the browser.| true |
| CORSOrigin | If CORS is enabled, define space-delimited Origins that are allowed to call the WebAPI from the browser. Example value: `"http://foo.bar http://localhost/ http://localhost *"`. Default value enables our [SuperOfficeGmail link][9] to talk to the web client. | |
| Documentation | Turn on/off Swagger/OpenAPI documentation generation for WebAPI. Turn off to reduce memory usage. | |

* **AuthorizeWithUsername** [enables username + password][4] (Basic) authentication. This method is not enabled in the Online environment.

* **AuthorizeWithTicket** enables SOTicket authentication.

* **AuthorizeWithImplicit** [enables authentication with IIS identity][3]. It means that your client has authenticated using Active Directory. This method is not enabled in the Online environment.

* **CORSEnable** turns on CORS headers, meaning that external sites must be listed in the CORSOrigin config to call the WebAPI. Default is on.

* **CORSOrigin** a list of space-separated URLs of sites that are allowed to call the WebAPI. If an external site tries to call, and it is not listed here, then the call will fail. You can use "*" to allow all sites to call.

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.WebApi>
[2]: ../../api-reference/restful/index.md
[3]: ../../authentication/webapi/enable-iis-identity.md
[4]: ../../authentication/webapi/enable-basic-auth.md
[9]: https://online.superoffice.com/AppStore/superoffice-as/superoffice-gmail-link
