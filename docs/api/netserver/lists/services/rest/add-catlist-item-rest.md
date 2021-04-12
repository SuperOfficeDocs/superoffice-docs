---
title: add_catlist_item_rest
description: Add a category list item
author: {github-id}
keywords: category,contact,rest
so.topic: howto           # article, howto, reference, concept, guide
so.date:

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
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
