---
title: Create a Contact entity
uid: create_contact_entity
description: Create a contact entity
author: {github-id}
so.date: 05.11.2016
keywords: entity
so.topic: howto
# so.envir:
# so.client:
---

# Create a Contact entity

Using the `Contact` [entity][1] exposed in the `SuperOffice.CRM.Entities` namespace is one of the easiest ways to create an appointment, as shown in the example below.

## Code

[!code-csharp[CS](includes/create-contact-entity.cs)]

## Walk-through

After an `SoSession` instance has been created and the user authenticated we can proceed to create a contact.

To create a contact, we create an instance of the `Contact` entity using the `CreateNew` methods exposed in the `Contact` class, after which the default values for the entity will be set using the `SetDefaults` method like this:

[!code-csharp[CS](includes/create-contact-entity.cs?range=7,11)]

The next section of the code shows [how values are assigned to properties][2] exposed by the entity.

Once the required values to the properties of the `Contact` entity have been added or assigned it could be saved with the `Save` method.

<!-- Referenced links -->
[1]: ../../netserver/entities/index.md
[2]: ../../netserver/entities/create-entity.md
