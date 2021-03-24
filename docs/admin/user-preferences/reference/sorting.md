---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: pref_sorting       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Preference section Sorting # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic: reference              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Preference section Sorting

[!include[SQL](./includes/to-view-pref.md)]

```SQL
SELECT * FROM UserPreference WHERE prefsection='Sorting'
```

Sorting - controls how various lists of people are presented to the user.

| Preference | Description | Control type | Access |
|---|---|---|---|
| SortingAssociates | The display format and sort order of associates in lists (e.g. Last name, First name or First name Last name) | List | Admin, Crm, Admin users, Wizard |
| SortingLists | The display format and sort order of items in lists (e.g. name or rank) | List | Admin, Crm, Admin users, Wizard |
| SortingPersons | The display format and sort order of contacts in lists (e.g. Last name, First name or First name Last name) | List | Admin, Crm, Admin users, Wizard |
