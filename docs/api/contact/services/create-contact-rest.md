---
title: Create a new company
uid: create_company_rest
description: How to create a new company using REST
author: {github-id}
so.date: 11.04.2021
keywords: contact, company, services, API, rest, JavaScript
so.topic: howto
# so.envir:
# so.client:
---

# Create a new company

Get a blank company, modify it, and post it back to create a new company.

```javascript
company = Get("api/v1/Contact/default")
company.Name = "New company"
company.Category.Id = 2
company = Post("api/v1/Contact", company)
```
