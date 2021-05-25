---
title: SuperId element
uid: ns_config_superid
description: NetServer SuperId element
so.date: 06.06.2018
author: {github-id}
keywords: config
so.topic: reference
so.envir: onsite
---

# NetServer SuperId element (SuperOffice only)

Configuration values for accessing SuperID.

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
| Url | URL to SuperID. |
| TenantKey | A shared secret between SuperID and NetServer. |
| TenantId | TenantId in SuperID. |
| Environment | Environment in SuperID. |
