---
# Mandatory fields.
title: list_contact_interests       # (Required) Very important for SEO.
description: How to list all selected interests for a contact  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: interest
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to list all selected interests for a contact

You can list all selected interests for a specific contact using the `ContactInterestHelper` class.

You can achieve the same with the `PersonInterestHelper` class.

The helper classes provide the functionality that combines the MDO lists and what to select (they combine entity sub-collections with MDO lists).

## Code

[!code-csharp[CS](includes/list-interests.cs)]

## Walk-through

In the code above, once we have created an instance of the `Contact` entity by using the `Contact` class, we use the contact’s `InterestHelper` to retrieve the selected interests. As shown above, we can retrieve the interest in 2 ways:

* using the `SelectHeadingItems` property
* using the `SelectRootItems` property
