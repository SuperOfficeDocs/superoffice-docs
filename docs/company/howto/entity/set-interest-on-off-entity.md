---
title: How to set an interest on or off
uid: toggle_contact_interest_entity
description: How to set an interest on or off for a contact using entities
author: {github-id}
so.date: 05.11.2016
keywords: contact, company, interest, entity, API, ContactInterestHelper, SetItemSelection
so.topic: howto
# so.envir:
# so.client:
---

# How to set an interest on or off for a contact (data layer)

You can search for an [interest][1] and then set the interest to true or false. Here, we use the `ContactInterestHelper`.

## Code

[!code-csharp[CS](includes/toggle-interest-entity.cs)]

## Walk-through

The `Find` method available through the `Contact` class’s `InterestHelper.RootItems` can be used to make our search.

[!code-csharp[CS](includes/toggle-interest-entity.cs?range=14-18)]

The method returns an `ISoListItem` and requires a delegate that defines the element for which we should search to be passed into the method. The method then returns any interest that matches our search interest by using the `Equals` method.

Next, we move on to setting the interest to true or false. To do this we use the `SetItemSelection` method available `ContactInterestHelper` class. The method requires the interest ID and the new selection status (true or false) to be passed.

<!-- Referenced links -->
[1]: ../../interests.md
