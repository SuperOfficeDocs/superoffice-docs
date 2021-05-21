---
title: Create a new company
uid: create_company
description: Create a new company
author: {github-id}
keywords: rest,contact
so.topic: howto
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Create a new company

Get a blank company, modify it, and post it back to create a new company.

```javascript
    company = Get("api/v1/Contact/default")
    company.Name = "New company"
    company.Category.Id = 2
    company = Post("api/v1/Contact", company)
```
