---
# Mandatory fields.
title: toggle_contact_interest_entity       # (Required) Very important for SEO.
description: How to set an interest on or off for a contact using entities # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: interest,contactinteresthelper
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to set an interest on or off for a contact (data layer)

You can search for an interest and then set the interest to true or false. Here, we use the `ContactInterestHelper`.

## Code

[!code-csharp[CS](includes/toggle-interest-entity.cs)]

## Walk-through

The `Find` method available through the `Contact` class’s `InterestHelper.RootItems` can be used to make our search.

[!code-csharp[CS](includes/toggle-interest-entity.cs?range=14-18)]

The method returns an `ISoListItem` and requires a delegate that defines the element for which we should search for to be passed into the method. The method then returns any interest that matches our search interest by using the `Equals` method.

Next, we move on to setting the interest to true or false. To do this we use the `SetItemSelection` method available `ContactInterestHelper` class. The method requires the interest ID and the new selection status (true or false) to be passed.
