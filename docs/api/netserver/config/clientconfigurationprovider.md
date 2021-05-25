---
title: ClientConfigurationProvider
uid: ns_config_client_configuration
description: NetServer ClientConfigurationProvider element
so.date: 06.06.2018
author: {github-id}
keywords: config
so.topic: reference
so.envir: onsite
so.client: web
---

# NetServer ClientConfigurationProvider element (SuperOffice only)

Configuration for the Web Client configuration data provider.

```XML
<ClientConfigurationProvider>
  <add key="CacheConfigurations" value="false" />
</ClientConfigurationProvider>
```

| Name | Description |
|---|---|
| FilePath | File path for standard .config files. |
| CacheConfigurations | Should GUI config data be cached? |
| CacheUserPreferences | Should GUI config data be cached?<br>Default: true |
| ValidateConfigurations | Should GUI config data be validated runtime? |
| CustomPath | List of alternate paths for GUI .config files. When more than one, each additional path must have a numbered suffix (CustomPath1, CustomPath2, ...) |
