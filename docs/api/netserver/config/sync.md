---
title: Sync element
uid: ns_config_sync
description: NetServer configuration values related to SuperOffice Sync (SoSync).
so.date: 12.07.2021
author: Bergfrid Dias
keywords: config, NetServer, web.config, Sync, SoSync, synchronization, SoSyncAdmin, SettingsAbsoluteExpiration, SettingsSlidingExpiration
so.topic: reference
so.envir: onsite
---

# NetServer Sync element (legacy SuperOffice only)

Configuration values related to SuperOffice Sync (SoSync).

Settings related to synchronization are configured using the SoSyncAdmin client, stored in the SuperOffice database, and internally in SoSync held in a cache. This cache has two time-out values. One of the values is related to the absolute expiry time after the value is inserted in the cache and the second relates to the expiry time since the value was last used.

| Name | Description | Default |
|---|---|---|
| SettingsAbsoluteExpiration | The time since read from the database. | 900 seconds |
| SettingsSlidingExpiration | The time since last used. | 300 seconds |

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.Sync>
