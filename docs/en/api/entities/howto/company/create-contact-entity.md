---
uid: create-contact-entity
title: Create a Contact entity
description: Create a contact entity
keywords: contact, company, entity, API, assert, SetDefaults
author: Bergfrid Dias
date: 02.22.2022
content_type: howto
redirect_from:
  - /en/company/howto/entity/create-contact-entity
  - /en/api/netserver/entities/howto/company/create-contact-entity
---

# Create a Contact entity

Using the `Contact` [entity][1] exposed in the `SuperOffice.CRM.Entities` namespace is one of the easiest ways to create a follow-up, as shown in the example below.

## Code

[!code-csharp[CS](includes/create-contact-entity.cs)]

## Walk-through

After an `SoSession` instance has been created and the user authenticated we can proceed to create a contact.

To create a contact, we create an instance of the `Contact` entity using the `CreateNew` methods exposed in the `Contact` class, after which the default values for the entity will be set using the `SetDefaults` method like this:

[!code-csharp[CS](includes/create-contact-entity.cs?range=7,11)]

The next section of the code shows [how values are assigned to properties][2] exposed by the entity.

Once the required values to the properties of the `Contact` entity have been added or assigned it could be saved with the `Save` method.

## Using assert

```csharp
using SuperOffice.CRM.Entities;

//Anonymous user has no righst to check out this stuff!
SuperOffice.SoSession session = SuperOffice.SoSession.Authenticate("Sal1", "" );
Contact contact = Contact.CreateNew();

// Verify flags on RDB
Assert.IsTrue( contact.IsNew, "The contact is new" );
Assert.IsTrue( !contact.IsDirty, "The contact is not dirty" );
Assert.IsTrue( !contact.IsDeleted, "The contact is not deleted" );

// Set properties on entity
contact.ActiveInterests = 2;
contact.Row.BusinessIdx = 1;
contact.Row.CategoryIdx = 1;
contact.Row.CountryId = 47;
contact.Name = "Geir er tøff AS";
contact.Department = "Søndre avdeling (lukket)";
contact.PostalAddress.Address1 = "Adresse1 Gaten 23";
contact.PostalAddress.Address2 = "Adresse 2 gata 54";
contact.PostalAddress.Address3 = "Adresse 33 street";
contact.PostalAddress.Zipcode = "0123";

// Verify flags on RDB
Assert.IsTrue( contact.IsNew, "The contact is new" );
Assert.IsTrue( contact.IsDirty, "The contact is dirty" );
Assert.IsTrue( !contact.IsDeleted, "The contact is not deleted" );

contact.Save();
```

<!-- Referenced links -->
[1]: ../../index.md
[2]: ../../create-entity.md
