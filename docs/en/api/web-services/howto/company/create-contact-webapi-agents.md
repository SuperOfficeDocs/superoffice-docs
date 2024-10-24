---
uid: create-company-webapi-agents
title: Create a new company
description: How to create a new Company using webapi contact agent.
keywords: contact, company, services, API, WebAPI, agents, CreateDefaultContactEntity, JavaScript
author: Bergfrid Dias
date: 11.18.2021
topic: howto
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

[!include[Pseudocode](../../../includes/note-javascripty.md)]
