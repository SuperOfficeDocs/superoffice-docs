---
title: Update a person with a new name, address, position using rows
uid: update_person_rows
description: How to update a person with new name, address, position using rows.
author: {github-id}
so.date: 05.11.2016
keywords: person, contact, API, rows, PersonRow, update, AddressRow
so.topic: howto
# so.envir:
# so.client:
---

# Update a person with a new name, address, position using rows

Now let's focus on how we can update the person's name, position, and address using rows.

## Code

The following example uses rows exclusively.

[!code-csharp[CS](includes/update-person-rows.cs)]

## Walk-through

We use the person row to change the name and the position of the person. Here we have assumed that we know the position ID of the position row that we want so we simply give that ID as the person’s position ID.

We changed the address of the person using an address row independent of the person row. Here we have retrieved the address row of the person using the address type and the person ID so we know that this is the address that was assigned to this person.

We have to save the person row and the address row separately since they are 2 different objects.
