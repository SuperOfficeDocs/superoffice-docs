---
# Mandatory fields.
title: add_catlist_item       # (Required) Very important for SEO.
description: Add a category list item # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
keywords: category,contact,rest
so.topic: howto           # article, howto, reference, concept, guide
so.date:

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Add a category list item

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
