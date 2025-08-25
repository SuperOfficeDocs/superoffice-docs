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
redirect_from:
  - /en/api/web-services/howto/company/create-contact-rest
  - /en/api/web-services/howto/company/create-contact-services
  - /en/api/web-services/howto/company/create-contact-webapi-agents
  - /en/company/howto/services/create-contact-rest
  - /en/api/netserver/web-services/howto/company/create-contact
  - /en/api/netserver/web-services/howto/company/create-contact-rest
  - /en/api/netserver/web-services/howto/company/create-contact-services
  - /en/api/netserver/web-services/howto/company/create-contact-webapi-agents
  - /en/company/howto/services/create-contact-services
  - /en/company/howto/services/create-contact-webapi-agents
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

```csharp
using SuperOffice.CRM.Services;
using SuperOffice;

using(SoSession newSession = SoSession.Authenticate("SAL0", ""))
{
  //Retrieve a ContactAgent
  using(ContactAgent contactAgent = new ContactAgent())
  {
    //Create a new contact Entity with default values set to its properties
    ContactEntity myContact = contactAgent.CreateDefaultContactEntity();

    //Assign values to various properties of the contact entity

    //Assign values to properties of basic data types
    myContact.Name = "Paba Inc.";
    myContact.Department = "Head office";
    myContact.NoMailing = true;

    //Create an array of EntityElement and assign it to the Phones property
    EntityElement[] myPhones = new EntityElement[2];
    myPhones[0] = new EntityElement();
    myPhones[1] = new EntityElement();
    myPhones[0].Value = "0112732006";
    myPhones[1].Value = "0713243288";
    myContact.Phones = myPhones;

    // Set the new contact’s  our-contact to associate 2
    using(AssociateAgent associateAgent = new AssociateAgent())
    {
      Associate myAssociate = associateAgent.GetAssociate(2);
      myContact.Associate = myAssociate;

      // Set the contact’s address
      myContact.Address[0][0].Value = "98/1,Main Street, Inland";
      myContact.Address[3][0].Value = "10620,";
      myContact.Address[3][1].Value = "Inland";  

      //Save the Contact Entity and the new person through the ContactAgent
      // the returned entity has the contact ID filled in
      myContact = contactAgent.SaveContactEntity(myContact);
    }
  }
}
```

Here we have used a `ContactAgent` and the `CreateDefaultContactEntity` method to create a new contact entity with default values filled in. We first set some of the basic values like name and department.

Then we have set values to properties of complex data types such as `EntityElement[]` types, entity types such as `Associate`, entity collection types such as `Persons`, and `LocalizedField` types.

Finally, the newly created contact entity is saved to the database using the `SaveContactEntity` method of the agent. With this, a new record will be added to the contact table in the database with its fields set to values that have been assigned.

The entity is returned with the allocated ID filled in.

***
