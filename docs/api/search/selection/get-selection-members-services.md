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

This method of retrieving all members of a Selection is with the use of the `ArchiveProvider` (services) as shown in the example below.

The selection member list is a list of contact and person IDs. The archive expands the contact and person information without the client needing to know how the expansion is happening.

[!code-csharp[CS](includes/get-members-services.cs)]

Notice how we use the restriction parameter.

[!code-csharp[CS](includes/get-members-services.cs?range=20-21)]

We create an `ArchiveRestricitonInfo` to define which selections we want information for. The selection may be a dynamic selection, which uses additional criteria to figure out which Contacts and/ or Persons are members of it. In this case, the `ArchiveProvider` used inside the agent will figure out how to read the selection member, depending on the selection type (dynamic or static).

## Output

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

[Read more about using the ArchiveAgent][1]

<!-- Referenced links -->
[1]: ../iarchiveagent/index.md
