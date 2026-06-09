---
uid: so-protocol-page-control
title: Page control and cache
description: SoProtocol page control and cache
keywords: soprotocol, deeplinking, cache
author: Tony Yates, digitaldiina, MargretheR
date: 06.10.2026
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

| Mode | Description |
|:--|:--|
| Flush | Flushes the client cache (`?flush`) |
| Refresh | Refreshes the current page (`?refresh`) |

### Service redirects

Use `service.{program}?action={action}` to redirect to Customer Service screens:

```html
superoffice:service.ticket?action=listTickets&ticket_id=123
```

The `flush` command can also be used inline within a navigation path:

```html
contact[flush=true].main
```

### Examples

* To flush the cache: `superoffice:contact.main?flush`
* To refresh the current page: `superoffice:contact.main?refresh`
* To navigate to a specific request in Customer Service: `superoffice:service.ticket?action=listTickets&ticket_id=123`
