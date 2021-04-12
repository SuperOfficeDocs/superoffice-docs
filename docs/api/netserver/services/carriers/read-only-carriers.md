---
# Mandatory fields.
title: read_only_carriers       # (Required) Very important for SEO.
description: Read-only carriers # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date:
keywords:
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Read-only carriers

A read-only carrier is a simple object. It exposes its properties primarily as simple string values. A read-only carrier will expose the country property as a country name and not as a country sub-object.

The advantage of the read-only carrier is its simplicity and you can avoid many overheads by working with an entity carrier.

Below is an example that displays how to load a read-only carrier using an Agent.

```csharp
using SuperOffice.CRM.Services;

ContactAgent contactAgent = new ContactAgent();
Contact myContact = contactAgent.GetContact(4);
string myContactName = myContact.Name;
string myContactCategory = myContact.CategoryName;
string myContactWebUrl = myContact.URL;
```

In the above example, the `ContactAgent` will return a `Contact` read-only object through the `GetContact` method. These kinds of objects are what we call read-only carriers.
