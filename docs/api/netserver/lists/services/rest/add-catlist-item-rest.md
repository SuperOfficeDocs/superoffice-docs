---
title: Add a category list item using REST
uid: add_catlist_item_rest
description: Add a category list item
author: {github-id}
keywords: category,contact,rest
so.topic: howto
so.date:
# so.envir:
# so.client:
---

# Add a category list item using REST

```javascript
var item = {}
item.Name = "Created by unit test";
item.Tooltip = "Unit Tests FTW";
item = Post("api/v1/List/Category/items", item)
```

The list item will be added - we can get the whole list here:

```javascript
item = Get("api/v1/List/Category/items", item)
```
