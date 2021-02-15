---
# Mandatory fields.
title: search_saint_findcontactprovider      # (Required) Very important for SEO.
description: Search for contacts with a given SAINT counter FindContactProvider # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: findprovider
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Search for contacts with a given SAINT counter using the FindContactProvider

With the use of `FindContactProvider`, you can search for contacts with a given SAINT counter value.

The following example demonstrates how it is done.

## Code

[!code-csharp[CS](includes/search-saint-provider.cs)]

![05][img1]

Initially, we have created an instance of the `FindContactProvider` class.

> [!TIP]
> You can set the return fields of the contact provider via the `SetDesiredColumns` method.

The `FindContactProvider` contains fields that belong to other tables than contact like `person` and `countervalue`. Hence you can add a restriction to a field in the table.

We want to retrieve the IDs of all the contacts with `saintsalestatus` value equal to 2. They are displayed in the console window and the latter part of the code is used to display the results.

<!-- Referenced images -->
[img1]: media/image005.jpg
