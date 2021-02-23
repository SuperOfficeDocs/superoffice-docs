---
# Mandatory fields.
title: search_saint_findagent      # (Required) Very important for SEO.
description: Search for contacts with a given SAINT counter  # (Required) Important for SEO.
author: {github-id}             # Your GitHub alias.
so.date: 06.24.2016
keywords: api-serices
so.topic: howto            # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Search for contacts with a given SAINT counter

We can do a search based on both Contact or Project counters and find contacts or projects that match these counters.

## Code

[!code-csharp[CS](includes/search-saint-findagent.cs)]

## Walk-through

**Output:**

```text
contactPhone/formattedNumber address/city address/zip  nameDepartment       NumberOfActivities
00 47 04                 OSLO          0123       Bjørge AS, BAvdeling   2
```

In the example we have used the `FindFromRestrictions` method available through the `FindAgent` to retrieve the information.

**Required parameters:**

* `restriction` – an array of restrictions specifying the search. Each restriction must match a column of the given archive provider, and that column must have its `canRestrict` property set to *true*.

  Here we have restricted the rows based on the `NumberOfActivities`. Since this is a restriction on SAINT, it is necessary to add certain sub restrictions as shown in the example.

* `SaintActivityType` – this is for indicating whether it is a phone call, meeting, to-do, or document. For example, when you create a phone call appointment it updates two counters: one counter for all activities and another for phone activities.

* `Direction` – indicates the direction of the appointment (in, out, or none). In this case too, 2 counters will be update: one counter for All direction and another for In or Out directions.

* `SaintIntention` – a list that can be edited using the admin client.

* `providerName` – the name of the archive provider that is to execute the search and resultant columns and rows.

* `pageNumber` – the result-set page to return (first). When a call returns no rows, no further pages will be available.

Once the rows have been fetched using the agent, we can retrieve the data by looping through the result set as shown above.
