---
title: Webhooks element
uid: ns_config_webhooks
description: NetServer Webhooks element
so.date: 06.06.2018
author: {github-id}
keywords: config
so.topic: reference
so.envir: onsite
---

# NetServer Webhooks element

Configure values related to webhooks - events broadcast to remote servers.

```XML
<Webhooks>
  <add key="EnableWebhooks" value="true" />
  <add key="RequireHttps" value="true" />
  <add key="ValidateHttps" value="true" />
</Webhooks>
```

| Name | Description |
|---|---|
| EnableWebhooks | Broadcast events to remote servers.<br>Default: false |
| RequireHttps | Require webhooks target URLs to use HTTPS protocol. Should only be turned off during development.<br>Default: true |
| ValidateHttps | Require valid public HTTPS certificates. Self-signed or expired certs on webhook target URLs are refused. Should only be turned off during development.<br>Default: true |
| NumThreads | How many background threads to run for dispatching webhooks. Default 0 = scale automatically according to demand |
| Timeout | Stop background threads after X number of seconds of idle time. Default 30 seconds |
