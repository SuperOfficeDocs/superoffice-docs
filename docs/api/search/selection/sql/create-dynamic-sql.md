---
title: create_dynamic_selection_sql
description: Create dynamic selection using raw SQL
author: {github-id}
keywords: 
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Create a dynamic selection

The structure of a dynamic selection is defined by several tables that contain the criteria definitions.

> [!NOTE]
> Since the structure is complex and is easy to get wrong it is strongly recommended to use the COM objects or the NetServer APIs to create and modify the criteria instead of doing it directly.

![x][img1]

The above selection's corresponding `Selection` table’s row can be seen as follows.

![x]()

> [!NOTE]
> `selType = 1` This indicates that it is a dynamic selection.

The actual criteria are stored in the `searchCriteria` table:

```SQL
SELECT * FROM CRM.searchcriteria WHERE ownerTable = 23 AND ownerId = 56
```

![x][img2]

This criteria contains one criteria group:

```SQL
SELECT * FROM CRM.searchcriteriagroup WHERE SearchCriteria_id = 14
```

![x][img3]

This group contains one or more search criterion records: each criterion corresponds to a field.

```SQL
SELECT * FROM CRM.searchcriterion WHERE SearchCriteriaGroup_id = 11
```

![x][img4]

> [!NOTE]
> The `contact.name` field (1281) is stored in the `criterionId`. The `extraId` is used when referencing to the SAINT counters. `OperatorID = 18` references to the operator `Begins with`.

The actual value that we want to search for is stored in a separate table, which enables us to use multiple values for each search criterion.

```SQL
SELECT * FROM CRM.searchcriterionvalue WHERE SearchCriterion_id = 12
```

![x][img5]

> [!NOTE]
> The fields that need to be filled depend on the field used in the `criterionId`. `Contact.Name` is a string value, so the `StringValue` field in the `criterionValue` should be filled out.

## Find dialog

The search criteria tables are also used when defining extra fields in the **Find** dialog. This is where the active flag is used. Un-checking a search field in the **Find** dialog corresponds to setting active = 0.

<!-- Referenced images -->
[img1]: media/dynamic-selection-dialog.jpg
[img2]: media/dynamic-selection-db2.jpg
[img3]: media/dynamic-selection-db3.jpg
[img4]: media/dynamic-selection-db4.jpg
[img5]: media/dynamic-selection-db5.jpg
[img6]: media/dynamic-selection-db1.jpg
