---
title: contact      
description: Contact
author: {github-id}             # Your GitHub alias.
so.topic: generic
keywords:
---

# Contact

The Contact entity represents a business object. It contains a set of properties bundled up as a single unit representing a particular business object. Entities contain properties of different data types such as properties of basic data types like int, string, boolean, entities, entity arrays, EntityElement, and LocalizedField.

> [!NOTE]
> The `Person` property of the `ContactEntity` is a *read-only* `Person` item and not a `PersonEntity`.

## Create contacts

You can create a contact at multiple levels of NetServer:

* [Create a contact entity][1]
* [Create a contact entity through an entity][2]
* [Create a contact entity through an entity collection][3]
* [Create a contact row][4]
* [Create a contact through row collection (Rows)][5]
* [Create a contact through OSQL][6]

## Get contact entity

You can get a `Contact` entity either by using the classes provided in the entities layer or by using the agents in the services layer.

* [Get a contact through Entities layer][7]
* [Get a contact through Services layer][8]

<!-- Referenced links -->
[1]: create/create-contact-entity.md
[2]: create/create-contact-entity-in-entity.md
[3]: create/create-contact-entity-in-collection.md
[4]: create/create-contact-row.md
[5]: create/create-contact-rows.md
[6]: create/create-contact-osql.md
[7]: get/get-contact-via-entities-layer.md
[8]: get/get-contact-via-services-layer.md
