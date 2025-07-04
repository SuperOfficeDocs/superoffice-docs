---
uid: create-contact-row
title: Create a contact row
description: Create a contact row
keywords: company, contact, API, row, ContactRow
author: Tony Yates
date: 05.11.2016
content_type: howto
redirect_from: /en/company/howto/row/create-contact-row
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
