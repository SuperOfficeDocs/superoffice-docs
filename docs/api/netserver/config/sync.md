---
title: Sync element
uid: ns_config_sync
description: NetServer Sync Element
so.date: 06.06.2018
author: {github-id}
keywords: config
so.topic: reference
so.envir: onsite
---

# NetServer Sync element (legacy SuperOffice only)

Configuration values related to SuperOffice Sync (SoSync).

Settings related to synchronization are configured using the SoSyncAdmin client, stored in the SuperOffice database, and internally in SoSync held in a cache. This cache has two time-out values. One of the values is related to the absolute expiry time after the value is inserted in the cache and the second relates to the expiry time since the value was last used.

| Name | Description |
|---|---|
| SettingsSlidingExpiration | The time since last used.<br>Default: 300 seconds |
| SettingsAbsoluteExpiration | The time since read from the database.<br>Default: 900 seconds |
