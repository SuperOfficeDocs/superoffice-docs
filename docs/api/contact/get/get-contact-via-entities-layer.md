---
# Mandatory fields.
title: get_contact_entity_layer       # (Required) Very important for SEO.
description: Get a Contact through Entities layer  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: entity
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Get a contact through entities layer

Getting a contact through the **entities layer** is pretty straight forward. You need to import the `SuperOffice.CRM.Entities` namespace.

The following example shows how it is done.

```csharp
using SuperOffice;
using SuperOffice.CRM.Entities;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Get a contact through Idx class
  Contact contactThroughIdx = Contact.GetFromIdxContactId(3);

  //Access the Name property
  string name = contactThroughIdx.Name;
}
```

When retrieving a `Contact` entity through Idx class, you have to pass the ID of the entity. Then all its properties will be retrieved from the database and kept in memory. This allows you to access the properties.

You can alternatively [use the services layer][1].

<!-- Referenced links -->
[1]: get-contact-via-services-layer.md
