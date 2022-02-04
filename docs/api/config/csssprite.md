---
title: CssSprite element
uid: ns_config_csssprite
description: NetServer configuration for the Web client CssSprite generator.
so.date: 12.17.2021
author: Bergfrid Dias
keywords: NetServer, web.config, CssSprite, paths, MaxHeight
so.topic: reference
so.envir: onsite
so.client: web
---

# NetServer CssSprite element (SuperOffice only)

Configuration for the Web client **CssSprite** generator. Used by SuperOffice only.

| Name | Description | Default |
|---|---|---|
| Enabled | By enabling this feature an image is created, containing most icons used in the application. | true |
| ExcludePaths | Paths to exclude. Do not include root path. Semicolon-separated list. | LargeFlag |
| MaxHeight | The maximum height of an icon allowed in the sprite. Icons higher are excluded. | 100 |
| MaxWidth | The maximum width of an icon allowed in the sprite. Icons wider are excluded. | 100 |
| PersistentPath | Path to generated CssSprite file. | |
| RootPath | Image path. | Images\Seven |

See the [NetServer Core reference][1] for details about handling this programmatically.

<!-- Referenced links -->
[1]: <xref:SuperOffice.Configuration.ConfigFile.CssSprite>
