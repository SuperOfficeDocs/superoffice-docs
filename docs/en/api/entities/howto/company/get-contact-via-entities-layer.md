---
uid: get-contact-entity-layer
title: Get a contact through entities layer
description: How to get a Contact through Entities layer.
keywords: contact, company, entity, API, GetFromIdxContactId
author: Tony Yates
date: 05.11.2016
content_type: howto
redirect_from:
  - /en/company/howto/entity/get-contact-via-entities-layer
  - /en/api/netserver/entities/howto/company/get-contact-via-entities-layer
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
[1]: ../../../web-services/howto/company/get-contact-via-services-layer.md
