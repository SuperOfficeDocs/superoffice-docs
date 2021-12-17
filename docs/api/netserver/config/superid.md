---
title: SuperId element
uid: ns_config_superid
description: NetServer configuration values for accessing SuperID.
so.date: 12.09.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, SuperID, TenantKey, TenantId, Environment
so.topic: reference
so.envir: onsite
---

# NetServer SuperId element (SuperOffice only)

Configuration values for accessing [SuperID][2].

```XML
<SuperId>
  <add key="Url" value="" />
  <add key="TenantKey" value="" />
  <add key="TenantId" value="" />
  <add key="Environment" value="" />
</SuperId>
```

| Name | Description |
|---|---|
| Environment | Environment in SuperID. |
| TenantId | TenantId in SuperID. |
| TenantKey | A shared secret between SuperID and NetServer. |
| Url | URL to SuperID. |

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.SuperId>
[2]: ../../../../superoffice-docs/docs/identity-management/superid/overview.md
