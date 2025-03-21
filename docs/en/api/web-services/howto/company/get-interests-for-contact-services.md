---
uid: list-contact-interests-ws
title: How to list all selected interests
description: How to list all selected interests for a contact using services
keywords: contact, company, services, API, interest, ContactAgent, SelectableMDOListItem
author: Tony Yates
date: 11.04.2021
topic: howto
---

# How to list all selected interests for a contact (services)

You can use  `SuperOffice.Services` and `SuperOffice.Services.Impl` DLLs to list all selected [interests][1] for a specific contact.

## Code

[!code-csharp[CS](includes/list-interests-services.cs)]

## Walk-through

Using the `ContactAgent`, we first retrieve a `Contact` entity. Next is to retrieve the available interests of the contact. We use the `Interests` property of the entity and retrieve the interest list into a `SelectableMDOListItem` array.

By iterating on the array, we can retrieve details of each interest available. Since we want only the *selected* interest, we add an if-condition to filter out any item that is not selected.

Comparing the **Interest** tab of the **Company** card in the SuperOffice and our obtained output we can confirm our results.

<!-- Referenced links -->
[1]: ../../../../company/reference/index.md#interests
