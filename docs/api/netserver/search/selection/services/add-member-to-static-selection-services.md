---
title: How to add members to a static selection using the services layer
uid: add_members_static_selection_services
description: How to add members to a static selection using services
author: {github-id}
so.date: 05.11.2016
keywords: search,services
so.topic: howto
# so.envir:
# so.client:
---

# How to add members to a static selection using the services layer

## Example 1

[!code-csharp[CS](includes/add-to-static-services-1.cs)]

In the above example, we create all the agents we require. We have used the methods provided in the contact agent to retrieve the contact we want to add its persons to a selection.

We have used the `AddConactSelectionMembers` method of the selection agent to add the members to a static selection. As you can see, the second parameter of the method is an array of `ContactPersonId` objects. In the example, we loop through the `persons` array of the contact entity and adding the person IDs to the `ContactPersonId` array. By doing this, we do not need to add the specific `person_id`, but if we want it’s also possible to add a new selection member by `person_id`. As one can see, we have added only one contact person to the selection, but if we want we can add persons from different contacts to a static selection.

## Example 2

Below is an example that shows how we can add members from different contacts to a static selection. Here we hard code the `contact_id` and `person_id`.

[!code-csharp[CS](includes/add-to-static-services-1.cs)]

> [!NOTE]
> We have given the `Contact_id` and the `Person_id` to each element of the `ContactPersonId` array. **Always give the number of a person** belonging to the contact that we specify for that element. For example, in the `person` table, the person with `person_id=83` must have a `person.contact_id=35`.
