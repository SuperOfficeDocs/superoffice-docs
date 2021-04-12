---
title: add_catlist_item_listagent
description: Add a category list item using WebAPI agents
author: {github-id}
keywords: category, contact, webapi,agents
so.topic: howto          # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
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
