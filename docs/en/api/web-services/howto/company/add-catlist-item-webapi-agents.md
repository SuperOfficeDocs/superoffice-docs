---
uid: add-catlist-item-listagent
title: Add a category list item
description: Add a category list item using WebAPI agents
keywords: category, contact, WebAPI, agents
author: Bergfrid Dias
date: 11.18.2021
content_type: howto
---

# Add a category list item

```javascript
var item = {}
item.Id = 0;
item.Name = "Created by unit test";
item.Tooltip = "Unit Tests FTW";
item.UdListDefinitionId = -64 // Category list ID
item = Post("api/v1/Agents/List/SaveListItemEntity", item)
```

The list item will be added - we can get the whole list here:

```javascript
req = { UdListDefinitionName: "category", IncludeDeleted: true }
items = Post("api/v1/Agents/List/GetAllFromListName", req)
```

[!include[Pseudocode](../../../includes/note-javascripty.md)]
