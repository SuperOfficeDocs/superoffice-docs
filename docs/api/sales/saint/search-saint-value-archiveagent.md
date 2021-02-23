---
# Mandatory fields.
title: search_saint_archiveagent      # (Required) Very important for SEO.
description: Search for contacts with a given SAINT value  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 06.24.2016
keywords: api-serices
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Search for contacts with a given SAINT value

In this example, we will retrieve all the contacts whose SAINT values are set to active.

## Code

[!code-csharp[CS](includes/search-saint-archiveagent.cs)]

## Walk-through

Here we are retrieving all contacts with `saintstatus1` set to true.

**Saintstatus1** refers to the first record in the `StatusDef` table. `Saintstatus2` refers to the second record and so on.

In the test database, `StatusDef` with ID 1 is called *Neglected Customer*. These names of the `StatusDef` can be found in the `LocaleTest` table.

Here, `Istrue` implies that the `issignalled` field in the `statusvalue` table. `Issignalled` field says whether the saint value is active or not.

**Output:**

```text
contactId   name                    department
[I:3]       Amadeus AS              AAvdeling
[I:4]       Name Changed 2          AAvdeling
[I:5]       Bjørge AS               BAvdeling
[I:6]       Bever Inc               BAvdeling
[I:7]       Colina AS               CAvdeling
[I:8]       Chevrolet Norge AS      CAvdeling
[I:9]       Delta Produkter AS      DAvdeling
[I:10]      xyz123                  DAvdeling
[I:11]      xyz                     EAvdeling
[I:12]      xyz                     EAvdelin
```
