---
uid: create-company-rest
title: Create a new company
description: How to create a new company using REST
keywords: contact, company, services, API, rest, JavaScript
author: Tony Yates
date: 11.04.2021
topic: howto
---

# Create a new company

Get a blank company, modify it, and post it back to create a new company.

```javascript
company = Get("api/v1/Contact/default")
company.Name = "New company"
company.Category.Id = 2
company = Post("api/v1/Contact", company)
```
