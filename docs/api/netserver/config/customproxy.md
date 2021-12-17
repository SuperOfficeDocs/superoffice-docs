---
title: CustomProxy element
uid: ns_config_customproxy
description: NetServer configuration values for custom proxy and communication with the internet.
so.date: 12.07.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, CustomProxy, CustomProxyHost, CustomProxyPort, CustomProxySSLPort, UseCustomProxyForIntegrationServer, UseCustomProxyForPublicAccess, UseCustomProxyForWebhooks
so.topic: reference
so.envir: onsite
---

# NetServer CustomProxy element

Configuration values for **Custom Proxy** and communication with the internet.

```XML
<CustomProxy>
  <add key="UseCustomProxyForPublicAccess" value="false" />
  <add key="CustomProxyHost" value="" />
  <add key="CustomProxyPort" value="" />
</CustomProxy>
```

| Name | Description |
|---|---|
| CustomProxyHost | Host for custom proxy used when UseCustomProxyForPublicAccess or UseCustomProxyForIntegrationServer is set to true. |
| CustomProxyPort | Port for custom proxy used when UseCustomProxyForPublicAccess or UseCustomProxyForIntegrationServer is set to true. |
| CustomProxySSLPort | Port for custom SSL proxy used when UseCustomProxyForPublicAccess or UseCustomProxyForIntegrationServer is set to true and requires SSL on a custom port. |
| UseCustomProxyForIntegrationServer | Use Custom Proxy server, even for local addresses, when communicating to ErpSync and Remote (Online) Quote Connector. This value overrides machine and other config default settings for the proxy server. |
| UseCustomProxyForPublicAccess | Use Custom Proxy server, even for local addresses, when communicating to public internet services. This value overrides machine and other config default settings for the proxy server. |
| UseCustomProxyForWebhooks | Use Custom Proxy server, even for local addresses, when communicating to webhook services. This value overrides machine and other config default settings for the proxy server. |

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.CustomProxy>
