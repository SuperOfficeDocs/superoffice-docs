---
title: Update a person with a new name, address, position using entities
uid: update_person_entity
description: Update a person with new name, address, position using entities
author: {github-id}
so.date: 05.11.2016
keywords: entity
so.topic: howto
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Update a person with a new name, address, position using entities

Let's discuss how we can update the name, address, and position of an existing person using entities.

## Code

[!code-csharp[CS](includes/update-person-entity.cs)]

## Walk-through

In the above example, we have used a mix of entities and rows. We have taken rows here since some of the properties that are exposed by the person entity are rows. For example, the position property of the person is exposed as a row.

We first change the name of the person we want and then retrieve a position row and assign the retrieved row as the position of the person. We have changed the address by accessing the properties of the address row through the `person` property itself.

When we finally save the `person` property, the address that was assigned to the person will get updated with the new values we specified.
