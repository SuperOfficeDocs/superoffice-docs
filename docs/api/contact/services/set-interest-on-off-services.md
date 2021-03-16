---
title: toggle_contact_interest_ws
description: How to set an interest on or off for a contact using services
author: {github-id}
so.date: 06.24.2016
keywords: interest
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to set an interest on or off for a contact (services)

You can use web services to alter the selected status of an interest of a specific contact.

## Code

[!code-csharp[CS](includes/toggle-interest-services.cs)]

## Walk-through

We have first retrieved a `Contact` entity using the `IContactAgent`. And then used its `Interests` property to retrieve the contact’s interests into a `SelectableMDOListItem` array.

Next, we iterate on the array and change its Boolean `Selected` property status. By using the `SaveContactEntity` method available in the `Contact` agent, we save the modifications made to the entity.

**Before:**

![before][img1]

**After:**

![after][img2]

<!-- Referenced images -->
[img1]: media/image005.jpg
[img2]: media/image006.jpg
