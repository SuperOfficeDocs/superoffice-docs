---
# Mandatory fields.
title: get_selection_members_services      # (Required) Very important for SEO.
description: How to retrieve members of a specific selection using services # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 05.11.2016
keywords: search
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# How to retrieve members of a specific selection using services

We can select contact and persons through the selection interface in NetServer. Each selection returns members that match the selection criteria. For a static selection, these members are stored in the `selectionmember` table. Each selection is recorded in the `selection` table.

The following examples shows how to use the `ArchiveAgent` to retrieve members of a static selection whose `selectionId` is 58. The `ContactSelection` is used as the provider for selection members.

The selection member list is a list of contact and person IDs. The archive expands the contact and person information without the client needing to know how the expansion is happening.

## Example 1

[!code-csharp[CS](includes/get-members-services-1.cs)]

Notice how we use the restriction parameter.

[!code-csharp[CS](includes/get-members-services-1.cs?range=20-21)]

We create an `ArchiveRestricitonInfo` to define which selections we want information for. The selection may be a dynamic selection, which uses additional criteria to figure out which Contacts and/ or Persons are members of it. In this case, the `ArchiveProvider` used inside the agent will figure out how to read the selection member, depending on the selection type (dynamic or static).

**Output:**

```text
contactId   nameDepartment          fullName
[I:2]       StateZeroDatabase       Tje2
[I:2]       StateZeroDatabase       Tje1
[I:2]       StateZeroDatabase       Tje0
[I:2]       StateZeroDatabase       SuperBuilder SuperBuilder
[I:2]       StateZeroDatabase       SerNS03 NetServer
[I:2]       StateZeroDatabase       Ser5
[I:2]       StateZeroDatabase       Ser4
[I:2]       StateZeroDatabase       Ser3
[I:2]       StateZeroDatabase       Ser2
[I:2]       StateZeroDatabase       Ser1
```

## Example 2

[!code-csharp[CS](includes/get-members-services-2.cs)]

Here we display other properties related to members of the selection, such as the `contactId`, `personId`, and `selectionId`. When the `GetArchiveListByColumns` method of the ArchiveAgent is executed, the members that match the given criteria are retrieved from the `selectionmember` table.

**Output:**

```text
contactId   selectionId personId
[I:2]       [I:58]      [I:10]
[I:2]       [I:58]      [I:11]
[I:2]       [I:58]      [I:12]
[I:2]       [I:58]      [I:13]
[I:2]       [I:58]      [I:14]
[I:2]       [I:58]      [I:15]
[I:2]       [I:58]      [I:16]
[I:2]       [I:58]      [I:17]
[I:2]       [I:58]      [I:18]
[I:2]       [I:58]      [I:147]
```

[Read more about using the ArchiveAgent][1]

<!-- Referenced links -->
[1]: ../iarchiveagent/index.md
