---
title: How to list all selected interests for a contact
uid: list_contact_interests_entity
description: How to list all selected interests for a contact using entities
author: {github-id}
so.date: 05.11.2016
keywords: interest
so.topic: howto
# so.envir:
# so.client:
---

# How to list all selected interests for a contact

You can list all selected interests for a specific contact using the `ContactInterestHelper` class.

You can achieve the same with the `PersonInterestHelper` class.

The helper classes provide the functionality that combines the MDO lists and what to select (they combine entity sub-collections with MDO lists).

## Code

[!code-csharp[CS](includes/list-interests-entity.cs)]

## Walk-through

In the code above, once we have created an instance of the `Contact` entity by using the `Contact` class, we use the contact’s `InterestHelper` to retrieve the selected interests. As shown above, we can retrieve the interest in 2 ways:

* using the `SelectHeadingItems` property
* using the `SelectRootItems` property
