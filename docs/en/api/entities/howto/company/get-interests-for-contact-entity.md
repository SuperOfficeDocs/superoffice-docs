---
uid: list-contact-interests-entity
title: How to list all selected interests for a contact
description: How to list all selected interests for a contact using entities
keywords: contact, company, interest, entity, API, ContactInterestHelper, SelectHeadingItems, SelectRootItems
author: Tony Yates
date: 05.11.2016
topic: howto
---

# How to list all selected interests for a contact

You can list all selected [interests][1] for a specific contact using the `ContactInterestHelper` class.

You can achieve the same with the `PersonInterestHelper` class.

The helper classes provide the functionality that combines the MDO lists and what to select (they combine entity sub-collections with MDO lists).

## Code

[!code-csharp[CS](includes/list-interests-entity.cs)]

## Walk-through

In the code above, once we have created an instance of the `Contact` entity by using the `Contact` class, we use the contact’s `InterestHelper` to retrieve the selected interests. As shown above, we can retrieve the interest in 2 ways:

* using the `SelectHeadingItems` property
* using the `SelectRootItems` property

<!-- Referenced links -->
[1]: ../../../../company/reference/index.md#interests
