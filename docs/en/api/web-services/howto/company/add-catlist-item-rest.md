---
uid: add-catlist-item-rest
title: Add a category list item using REST
description: Add a category list item
keywords: category, contact, rest
author: Tony Yates
topic: howto
date: 10.22.2024
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
