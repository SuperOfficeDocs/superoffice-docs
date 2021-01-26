---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: dynamic_selection       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Dynamic selection # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: 
so.topic: concept              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Dynamic selections

The structure of a dynamic selection is defined by several tables that contain the criteria defintions. This structure is complex and easy to get wrong. We strongly urge you to use the COM objects or the NetServer APIs to create and modify the criteria instead of doing it directly.

![x][img1]

The corresponding Selection table row looks like this:

![x][img2]

> [!NOTE]
> The selType = 1 (dynamic)

The actual criteria are stored in the `searchCriteria` table:

```sql
SELECT * FROM searchcriteria WHERE ownertable=23 and ownerid=76
```

![x][img3]

This criteria contains one criteria group (the group concept is there to support more complex searches using AND/OR operators and so on - nothing is implemented yet though).

```sql
SELECT * FROM searchcriteriagroup WHERE searchcriteria_id = 24
```

![x][img4]

The group contains one or more search criterion records: each criterion corresponds to a field.

```sql
SELECT * FROM searchcriterion WHERE searchcriteriagroup_id = 20
```

![x][img5]

> [!NOTE]
> The [contact.name][1] field (1281) is stored in the `criterionI`. The `extraId` is used when referencing the [SAINT counters][2].

Operator 18 = Begins with

The actual value that we want to search for is stored in a separate table so that we can support multiple values per search criterion (for the is-one-of searches).

```sql
SELECT * FROM searchcriterionvalue WHERE searchCriterion_id = 24
```

![x][img6]

Which of the fields you need to fill in depends on the field used in the `criterionId`. `Contact.Name` is a string value, so the `stringValue` field in the `criterionValue` should be filled out.

## Find dialog

The search criteria tables are also used when defining extra fields in the find dialog. This is where the active flag is used. Unchecking a search field in the find dialog corresponds to setting `active=0`.

## See also

* [searchcriteria table][3]
* [searchcriteriagroup table][4]
* [searchcriterion table][5]
* [searchcriterionvalue table][6]
* [selection table][7]

<!-- Referenced links -->
[1]: ../../tables/contact.md
[2]: ../../sales/saint/counters.md
[3]: ../../tables/searchcriteria.md
[4]: ../../tables/searchcriteriagroup.md
[5]: ../../tables/searchcriterion.md
[6]: ../../tables/searchcriterionvalue.md
[7]: ../../tables/selection.md

<!-- Referenced images -->
[img1]: media/dynsel-card.png
[img2]: media/dynsel-row.png
[img3]: media/dynsel-searchcrit.png
[img4]: media/dynsel-searchcritgroup.png
[img5]: media/dynsel-searchcriterion.png
[img6]: media/dynsel-criterionvalue.png
