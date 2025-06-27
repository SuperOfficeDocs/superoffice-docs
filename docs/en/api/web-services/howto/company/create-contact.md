---
uid: api-create-contact
title: Create a new company
description: How to create a new company
keywords: contact, company, services, WebApi, rest, RPC, JavaScript CreateDefaultContactEntity, ContactAgent
author: Tony Yates, Eivind Fasting
date: 05.23.2025
version: 10
content_type: howto
audience: api
audience_tooltip: SuperOffice APIs and database
---

<!-- markdownlint-disable-file MD051 -->

# Create a new company

These examples show how to create a new default contact, assign values to the properties of the entity and save it using the different integration points in SuperOffice.

## [Restful REST](#tab/rest)

```javascript
company = Get("api/v1/Contact/default")
company.Name = "New company"
company.Category.Id = 2
company = Post("api/v1/Contact", company)
```

## [RPC Agent](#tab/rpc)

```javascript
company = Post("api/v1/Agents/Contact/CreateDefaultContactEntity")
company.Name = "New company"
company.Category.Id = 2
company.Business.Id = 3
company.NoMailing = true
company = Post("api/v1/Agents/Contact/SaveContactEntity", company)
```

[!include[Pseudocode](../../../includes/note-javascripty.md)]

## [Services](#tab/services)

[!code-csharp[CS](includes/create-contact-services.cs)]

Here we have used a `ContactAgent` and the `CreateDefaultContactEntity` method to create a new contact entity with default values filled in. We first set some of the basic values like name and department.

Then we have set values to properties of complex data types such as `EntityElement[]` types, entity types such as `Associate`, entity collection types such as `Persons`, and `LocalizedField` types.

Finally, the newly created contact entity is saved to the database using the `SaveContactEntity` method of the agent. With this, a new record will be added to the contact table in the database with its fields set to values that have been assigned.

The entity is returned with the allocated ID filled in.

***
