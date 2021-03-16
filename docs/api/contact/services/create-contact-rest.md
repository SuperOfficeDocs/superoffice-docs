---
# Mandatory fields.
title: create_company       # (Required) Very important for SEO.
description: Create a new company # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
keywords: rest,contact
so.topic: howto        # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
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
