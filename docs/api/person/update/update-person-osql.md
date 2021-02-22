---
# Mandatory fields.
title: update_person_osql       # (Required) Very important for SEO.
description: Update a person with new name, address, position using OSQL  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: osql
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Update a person with new name, address, position using OSQL

[!include[import OSQL namespaces](../../includes/using-osql.md)]

## Code

The following example uses OSQL exclusively.

[!code-csharp[CS](includes/update-person-osql.cs)]

## Walk-through

If we have to update several tables, we need several update instances. Above, we have 2 update instances for the 2 tables. We have given the update values separately in the update instances we have created for the 2 tables. When we have more than one command to be executed against the database, we have to use the batch save instance since it can hold many SQL commands.
