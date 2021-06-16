---
title: Add a category list item
uid: add_catlist_item_listagent
description: Add a category list item using WebAPI agents
author: {github-id}
keywords: category, contact, webapi, agents
so.topic: howto
# so.envir:
# so.client:
---

# Add a category list item

```javascript
var item = {}
item.Id = 0;
item.Name = "Created by unit test";
item.Tooltip = "Unit Tests FTW";
item.UdListDefinitionId = -64    // Category list ID
item = Post("api/v1/Agents/List/SaveListItemEntity", item)
```

The list item will be added - we can get the whole list here:

```javascript
req = { UdListDefinitionName: "category", IncludeDeleted: true }
items = Post("api/v1/Agents/List/GetAllFromListName", req)
```
