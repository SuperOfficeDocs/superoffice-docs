---
title: Creating a selection
uid: add_person_to_selection
description: Adding a person to a selection
author: {github-id}
so.date: 11.08.2021
keywords: search, selection, static
so.topic: howto
# so.envir:
# so.client:
---


# Creating a selection

![Selection dialog -screenshot][img1]

```SQL
INSERT INTO CRM."selection" ("selection_id", "associate_id", "group_idx", "name", "text_id", "postitText_Id", "visibility", "seltype", "searchCat_id", "companyUnique", "soundEx", "source", "memberCount", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount", "includePerson") VALUES (75, 10, 5, 'My First Selection', 0, 0, 1, 0, 1, 0, 'MAFRSTSLK', 0, 0, 1164904874, 10, 0, 0, 0, 0)

INSERT INTO CRM."visiblefor" ("VisibleFor_id", "tableId", "recordId", "forAll", "forGroupId", "forAssocId", "encryptedCheck", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (919, 23, 75, 0, 0, 10, 'aakJA2Mgv19Dhim5t3Q3gQ1Kjvg8L981', 1164904874, 10, 0, 0, 0)
```

## Adding a company to a static selection

```SQL
INSERT INTO CRM."selectionmember" ("selectionmember_id", "selection_id", "contact_id", "person_id") VALUES (1776, 75, 19, 0)
```

> [!NOTE]
> `person_id = 0`

## Adding a person to a static selection

```SQL
INSERT INTO CRM."selectionmember" ("selectionmember_id", "selection_id", "contact_id", "person_id") VALUES (1774, 75, 13, 41)
```

<!-- Referenced images -->
[img1]: media/add-member-static.png
