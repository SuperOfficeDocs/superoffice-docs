---
title: How to add members to a static selection using entities layer
uid: add_members_static_selection_entities
description: How to add members to a static selection using entities
author: {github-id}
so.date: 05.11.2016
keywords: search,entities
so.topic: howto
# so.envir:
# so.client:
---

# How to add members to a static selection using entities layer

The example demonstrates the use of entities to achieve the task.

## Code

[!code-csharp[CS](includes/add-to-static-entities.cs)]

## Walk-through

Here we have retrieved the contact entity that the persons that we want to add as members to the static selection belong to.

Now we can loop through the person collection of the contact entity and add the persons one by one as members of the static selection.

This example only adds persons from one contact, but if you want you may add persons from many contacts as members of a static selection. Also, you can notice the contact ID and the person ID has not been hard-coded, but if you want to this is also a possibility.

[!include[ALT](../includes/note-hardcoding-id.md)]
