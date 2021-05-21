---
title: Create a contact through row collection (Rows)
uid: create_contact_rows
description: Create a contact rows
author: {github-id}
so.date: 05.11.2016
keywords: rows,collection
so.topic: howto
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Create a contact through row collection (Rows)

Because the `Rows` type consists of a collection of `Row` objects, it is possible to create a `ContactRow` with the `ContactRows` class.

## Code

[!code-csharp[CS](includes/create-contact-rows.cs)]

## Walk-through

1. Instantiate the `ContactRows` class using the `CreateNew` method.

2. Instantiate a `ContactRow` class and assign the necessary values to it. The instance can then be added to the collection with the execution of the `Add` method.

3. Save the contact:

    [!code-csharp[CS](includes/create-contact-rows.cs?range=14,16)]
