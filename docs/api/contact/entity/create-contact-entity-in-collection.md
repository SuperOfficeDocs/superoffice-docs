---
title: Create a Contact entity through an entity collection
uid: create_contact_entity_in_collection
description: Create a Contact entity through an entity collection
author: {github-id}
so.date: 05.11.2016
keywords: entity,collection
so.topic: howto
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Create a Contact entity through an entity collection

The `SuperOffice.CRM.Entities` namespace exposes entity collections such as `ContactCollection` and `PersonCollection`. It is therefore possible to create a `Contact` entity and assign it to the collection and thereby saving the collection the `Contact` entity will be saved.

The following example demonstrates the method of doing the above.

## Code

[!code-csharp[CS](includes/create-contact-entity-in-collection.cs)]

## Walk-through

In the above code, a `Contact` entity has been created, and then it has been assigned to the instantiated `ContactCollection`.

Then the collection has been saved like this:

[!code-csharp[CS](includes/create-contact-entity-in-collection.cs?range=35-36)]
