---
title: Create a new company
uid: create_company_webapi_agents
description: Create a new Company
author: {github-id}
keywords: webapi, agents
so.topic: howto
# so.envir:
# so.client:
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
