---
title: Create a Contact entity through an entity
uid: create_contact_entity_in_entity
description: How to create a Contact entity through an entity two ways.
author: {github-id}
so.date: 05.11.2016
keywords: contact, company, entity, API,
so.topic: howto
# so.envir:
# so.client:
---

# Create a Contact entity through an entity

Creating a contact through an entity can be done in two different ways:

[!include[ALT](../../../api/includes/create-entity-options.md)]

## Example 1

[!code-csharp[CS](includes/create-contact-entity-in-entity-1.cs)]

In the example above, we create a new contact as explained in [this example][1]. The difference is that we do not save the created contact. Instead, we assign it to another entity such as the `Person` entity and then save the `Person`:

[!code-csharp[CS](includes/create-contact-entity-in-entity-1.cs?range=44,47)]

## Example 2

Below is the example of creating a `Contact` entity, which is a property of another entity, such as `Person`.

[!code-csharp[CS](includes/create-contact-entity-in-entity-2.cs)]

The difference between example 1 and example 2 is that here the properties of the `Contact` entity are accessed through the instance of the `Person` entity as shown below. However, the statements may vary a little depending on the data type.

[!code-csharp[CS](includes/create-contact-entity-in-entity-2.cs?range=12)]

When saving the `Person` entity with the use of the `Save` method the new `Contact` is also saved NestedPersistent).

> [!NOTE]
> When using the above type of code, the main entity (such as the `Person` entity above) should also be created. When retrieving a person, it may already have a contact assigned to it. So therefore when adding values to the properties of the `Contact` in such an entity, what we would actually be doing is updating the existing `Contact` information.

<!-- Referenced links -->
[1]: create-contact-entity.md
