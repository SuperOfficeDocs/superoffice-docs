---
title: How to set an interest on or off
uid: toggle_contact_interest_ws
description: How to set an interest on or off for a contact using services
author: {github-id}
so.date: 11.04.2021
keywords: contact, company, services, API, interest, IContactAgent, electableMDOListItem
so.topic: howto
# so.envir:
# so.client:
---

# How to set an interest on or off for a contact (services)

You can use web services to alter the selected status of an interest of a specific contact.

## Code

[!code-csharp[CS](includes/toggle-interest-services.cs)]

## Walk-through

We have first retrieved a `Contact` entity using the `IContactAgent`. And then used its `Interests` property to retrieve the contact’s interests into a `SelectableMDOListItem` array.

Next, we iterate on the array and change its Boolean `Selected` property status. By using the `SaveContactEntity` method available in the `Contact` agent, we save the modifications made to the entity.

<!-- Referenced images -->
