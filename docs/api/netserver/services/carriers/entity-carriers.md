---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: entity_carriers       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Entity carriers # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: concept

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Entity carriers

An entity carrier is an [entity][1] object. Unlike in read-only carriers, an entity carrier exposes its properties as objects that are populated with more detailed data. The properties will expose their properties since the properties in entity objects are objects themselves.

The example below displays how to load a `Contact` entity object using a `ContactAgent`.

```csharp
using SuperOffice.CRM.Services;

ContactAgent contactAgent = new ContactAgent();

ContactEntity myContact = contactAgent.GetContactEntity(4);

string myContactName = myContact.Name;
string myContactCategory = myContact.Category.Value;
string myContactWebUrl = myContact.Urls.Length > 0 ? myContact.Urls[0].Value : "";
```

The above example displays how to retrieve a `Contact` entity through the `GetContactEntity` method of the `ContactAgent`.

<!-- Referenced links -->
[1]: ../../entities/index.md
