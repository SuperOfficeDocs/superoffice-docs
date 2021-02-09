---
title: ns_config_customproxy
description: NetServer CustomProxy element
so.date: 06.06.2018
author: {github-id}
keywords: config
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
| UseCustomProxyForPublicAccess | Use Custom Proxy server, even for local addresses, when communicating to public internet services. This value overrides machine and other config default settings for proxy server. |
| UseCustomProxyForIntegrationServer | Use Custom Proxy server, even for local addresses, when communicating to ErpSync and Remote (Online) Quote Connector. This value overrides machine and other config default settings for proxy server. |
| UseCustomProxyForWebhooks | Use Custom Proxy server, even for local addresses, when communicating to webhook services. This value overrides machine and other config default settings for proxy server. |
| CustomProxyHost | Host for custom proxy used when UseCustomProxyForPublicAccess or UseCustomProxyForIntegrationServer is set to true. |
| CustomProxyPort | Port for custom proxy used when UseCustomProxyForPublicAccess or UseCustomProxyForIntegrationServer is set to true. |
| CustomProxySSLPort | Port for custom SSL proxy used when UseCustomProxyForPublicAccess or UseCustomProxyForIntegrationServer is set to true and requires SSL on a custom port. |
