---
# Mandatory fields.
title: get_contact_services_layer       # (Required) Very important for SEO.
description: Get a Contact through Services layer  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: api-services
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Get a contact through services layer

This is an alternative to retrieving a `Contact` entity [through the entities layer][1].

The following example shows how it is done.

```csharp
using SuperOffice.CRM.Services;
using SuperOffice ;
using(SoSession mySession = SoSession.Authenticate("SAL0", ""))
{
  //Create a Contact Agent
  IContactAgent myContactAgent = AgentFactory.GetContactAgent();

  //Get a Contact Entity through the Contact Agent
  Contact myContact = myContactAgent.GetContact(4);

  //Retrieving the Name Property of the Contact
  string name = myContact.Name;
}
```

First, you need to create a `ContactAgent`. Then we can retrieve a `Contact` entity carrier by passing the `Contact_id` to the `GetContact` method. At this moment, all the properties of this particular contact will be passed to memory from the database. Now you can access all the properties of this contact via this newly created `Contact` carrier.

<!-- Referenced links -->
[1]: get-contact-via-entities-layer.md
