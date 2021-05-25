---
title: Dynamic selections
uid: dynamic_selection
description: Dynamic selection
author: {github-id}
keywords: 
so.topic: concept
# so.envir:
# so.client:
---

# Dynamic selections

The structure of a dynamic selection is defined by several tables that contain the criteria definitions. This structure is complex and easy to get wrong. We strongly urge you to use the COM objects or the NetServer APIs to create and modify the criteria instead of doing it directly.

![x][img1]

The corresponding Selection table row looks like this:

![x][img2]

> [!NOTE]
> The selType = 1 (dynamic)

The actual criteria are stored in the `searchCriteria` table:

```SQL
SELECT * FROM searchcriteria WHERE ownertable=23 and ownerid=76
```

![x][img3]

This criterion contains one criteria group (the group concept is there to support more complex searches using AND/OR operators and so on - nothing is implemented yet though).

```SQL
SELECT * FROM searchcriteriagroup WHERE searchcriteria_id = 24
```

![x][img4]

The group contains one or more search criterion records: each criterion corresponds to a field.

```SQL
SELECT * FROM searchcriterion WHERE searchcriteriagroup_id = 20
```

![x][img5]

> [!NOTE]
> The [contact.name][1] field (1281) is stored in the `criterionI`. The `extraId` is used when referencing the [SAINT counters][2].

Operator 18 = Begins with

The actual value that we want to search for is stored in a separate table so that we can support multiple values per search criterion (for the is-one-of searches).

```SQL
SELECT * FROM searchcriterionvalue WHERE searchCriterion_id = 24
```

![x][img6]

Which of the fields you need to fill in depends on the field used in the `criterionId`. `Contact.Name` is a string value, so the `stringValue` field in the `criterionValue` should be filled out.

## Find dialog

The search criteria tables are also used when defining extra fields in the **Find** dialog. This is where the active flag is used. Un-checking a search field in the find dialog corresponds to setting `active=0`.

## See also

* [searchcriteria table][3]
* [searchcriteriagroup table][4]
* [searchcriterion table][5]
* [searchcriterionvalue table][6]
* [selection table][7]

<!-- Referenced links -->
[1]: ../../../../../database/docs/tables/contact.md
[2]: ../../../sales/saint/counters.md
[3]: ../../../../../database/docs/tables/searchcriteria.md
[4]: ../../../../../database/docs/tables/searchcriteriagroup.md
[5]: ../../../../../database/docs/tables/searchcriterion.md
[6]: ../../../../../database/docs/tables/searchcriterionvalue.md
[7]: ../../../../../database/docs/tables/selection.md

<!-- Referenced images -->
[img1]: media/dynsel-card.png
[img2]: media/dynsel-row.png
[img3]: media/dynsel-searchcrit.png
[img4]: media/dynsel-searchcritgroup.png
[img5]: media/dynsel-searchcriterion.png
[img6]: media/dynsel-criterionvalue.png
