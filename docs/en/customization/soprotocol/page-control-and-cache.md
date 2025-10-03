---
uid: so-protocol-page-control
title: Page control and cache
description: SoProtocol page control and cache
keywords: soprotocol, deeplinking, cache
author: Tony Yates
date: 10.03.2025
content_type: reference
category: customization
topic: soprotocol
redirect_from: /en/ui/soprotocol/page-control-and-cache
language: en
---

# Page control and cache

## Windows only

| Mode     | Description                              |
|:---------|:-----------------------------------------|
| Activate | Forces the application window to the top |
| Flush    | Forces refresh of all caches (Shift+F5)  |
| Refresh  | Forces refresh of all caches (F5)        |
| Reload   | Reloads selected caches                  |

### Examples

* To refresh the client: `superoffice:refresh?db_id=1010000006` or `superoffice:flush?db_id=1010000006`

* To bring the window to the front:

`superoffice:contact.personarchive.main.activate?db_id=98765&contact_id=5`

## Web only

| Mode     | Description                              |
|:---------|:-----------------------------------------|
| Flush    | QueryString parameter (...?flush)        |

<!-- Referenced links -->
