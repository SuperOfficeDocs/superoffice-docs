---
uid: toggle-contact-interest-ws
title: How to set an interest on or off
description: How to set an interest on or off for a contact using services
keywords: contact, company, services, API, interest, ContactAgent, electableMDOListItem
author: Tony Yates
date: 11.04.2021
topic: howto
---

# How to set an interest on or off for a contact (services)

You can use web services to alter the selected status of an [interest][1] of a specific contact.

## Code

[!code-csharp[CS](includes/toggle-interest-services.cs)]

## Walk-through

We have first retrieved a `Contact` entity using the `ContactAgent`. And then used its `Interests` property to retrieve the contact’s interests into a `SelectableMDOListItem` array.

Next, we iterate on the array and change its Boolean `Selected` property status. By using the `SaveContactEntity` method available in the `Contact` agent, we save the modifications made to the entity.

<!-- Referenced links -->
[1]: ../../../../company/reference/index.md#interests
