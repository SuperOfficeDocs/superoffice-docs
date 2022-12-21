---
title: Get a contact through the services layer
uid: get_contact_services_layer
description: How to get a Contact through Services layer.
author: {github-id}
so.date: 11.04.2021
keywords: contact, company, services, API, api-services, ContactAgent
so.topic: howto
# so.envir:
# so.client:
---

# Get a contact through the services layer

This is an alternative to retrieving a `Contact` entity [through the entities layer][1].

The following example shows how it is done.

## Code

```csharp
using SuperOffice.CRM.Services;
using SuperOffice;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Create a Contact Agent
  ContactAgent myContactAgent = new ContactAgent();

  //Get a Contact Entity through the Contact Agent
  Contact myContact = myContactAgent.GetContact(4);

  //Retrieving the Name Property of the Contact
  string name = myContact.Name;
}
```

## Walk-through

First, you need to create a `ContactAgent`. Then we can retrieve a `Contact` entity carrier by passing the `Contact_id` to the `GetContact` method. At this moment, all the properties of this particular contact will be passed to memory from the database. Now you can access all the properties of this contact via this newly created `Contact` carrier.

<!-- Referenced links -->
[1]: ../entity/get-contact-via-entities-layer.md
