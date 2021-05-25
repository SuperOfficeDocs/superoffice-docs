---
title: CssSprite element
uid: ns_config_csssprite
description: NetServer CssSprite element
so.date: 06.06.2018
author: {github-id}
keywords: config
so.topic: reference
so.envir: onsite
---

# NetServer CssSprite element (SuperOffice only)

Configuration for the Web client **CssSprite** generator. Used by SuperOffice only.

| Name | Description |
|---|---|
| Enabled |  By enabling this feature an image is created, containing most icons used in the application.<br>Default: true |
| RootPath | Image path.<br>Default: *Images\Seven* |
| PersistentPath | Path to generated CssSprite file. |
| ExcludePaths | Paths to exclude. Do not include root path. Semicolon-separated list.<br>Default: LargeFlag |
| MaxHeight | The maximum height of an icon allowed in the sprite. Icons higher are excluded.<br>Default: 100 |
| MaxWidth | The maximum width of an icon allowed in the sprite. Icons wider are excluded.<br>Default: 100 |
