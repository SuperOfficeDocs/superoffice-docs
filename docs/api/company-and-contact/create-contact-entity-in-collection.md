---
# Mandatory fields.
title: create_contact_entity_in_collection       # (Required) Very important for SEO.
description: Create a Contact entity through an entity collection  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: entity,collection
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
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
