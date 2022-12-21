---
title: SuspendedSite element
uid: ns_config_suspendedsite
description: NetServer configuration values related to the suspended state.
so.date: 12.07.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, SuspendedSite, download_baseurl, suspended
so.topic: reference
so.envir: onsite
---

# NetServer SuspendedSite element (SuperOffice only)

Configuration values related to the suspended state.

```XML
<SuspendedSite>
  <add key="suspended" value="" />
  <add key="download_baseurl" value="" />
</SuspendedSite>
```

| Name | Description |
|---|---|
| download_baseurl | Download base URL. |
| suspended | The current state of the site. |

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.SuspendedSite>
