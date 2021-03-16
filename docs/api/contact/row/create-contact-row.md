---
# Mandatory fields.
title: create_contact_row       # (Required) Very important for SEO.
description: Create a contact row  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: row
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
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
