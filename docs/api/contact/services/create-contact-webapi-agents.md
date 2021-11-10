---
title: Create a new company
uid: create_company_webapi_agents
description: How to create a new Company using webapi contact agent.
author: {github-id}
so.date: 11.04.2021
keywords: contact, company, services, API, webapi, agents, CreateDefaultContactEntity, JavaScript
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
