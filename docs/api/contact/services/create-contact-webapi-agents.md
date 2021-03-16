---
# Mandatory fields.
title: create_company       # (Required) Very important for SEO.
description: Create a new Company # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
keywords: webapi, agents
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Create a new company

Get a blank company, modify it, and post it back to create a new company.

```javascript
company = Post("api/v1/Agents/Contact/CreateDefaultContactEntity")
company.Name = "New company"
company.Category.Id = 2
company.Business.Id = 3
company.NoMailing = true
company = Post("api/v1/Agents/Contact/SaveContactEntity", company)
```
