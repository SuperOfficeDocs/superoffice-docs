---
title: Create a contact row
uid: create_contact_row
description: Create a contact row
author: {github-id}
so.date: 05.11.2016
keywords: company, contact, API, row, ContactRow
so.topic: howto
# so.envir:
# so.client:
---

# Create a contact row

To create a `ContactRow` we use the `SuperOffice.CRM.Rows` namespace.

The following example shows how we make create a contact using the `ContactRow` class.

## Code

[!code-csharp[CS](includes/create-contact-row.cs)]

## Walk-through

The first step is to instantiate the `ContactRow` class and then the next step is to set the default values of it with the `SetDefaults` method.

[!code-csharp[CS](includes/create-contact-row.cs?range=6,9)]

To access individual properties exposed through the `ContactRow` class we use statements like this:

[!code-csharp[CS](includes/create-contact-row.cs?range=10)]

Calling `Save()` available in the `ContactRow` class, the instantiated `ContactRow` will be saved in to the `contact` table.
