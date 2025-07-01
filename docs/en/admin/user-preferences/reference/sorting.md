---
title: Sorting
uid: pref_sorting
description: Preference section Sorting
author: SuperOffice Product and Engineering
keywords: database
topic: reference
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
