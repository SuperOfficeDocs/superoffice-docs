---
title: Get a contact through entities layer
uid: get_contact_entity_layer
description: Get a Contact through Entities layer
author: {github-id}
so.date: 05.11.2016
keywords: entity
so.topic: howto
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Get a contact through entities layer

Getting a contact through the **entities layer** is pretty straightforward. You need to import the `SuperOffice.CRM.Entities` namespace.

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

When retrieving a `Contact` entity through an Idx class, you have to pass the ID of the entity. Then all its properties will be retrieved from the database and kept in memory. This allows you to access the properties.

You can alternatively [use the services layer][1].

<!-- Referenced links -->
[1]: ../services/get-contact-via-services-layer.md
