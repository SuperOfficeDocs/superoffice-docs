---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: add_person_to_selection       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Adding a person to a selection # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: 
so.topic: howto              # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---


# Creating a selection

```SQL
INSERT INTO CRM5."selection" ("selection_id", "associate_id", "group_idx", "name", "text_id", "postitText_Id", "visibility", "seltype", "searchCat_id", "companyUnique", "soundEx", "source", "memberCount", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount", "includePerson") VALUES (75, 10, 5, 'My First Selection', 0, 0, 1, 0, 1, 0, 'MAFRSTSLK', 0, 0, 1164904874, 10, 0, 0, 0, 0)

INSERT INTO CRM5."visiblefor" ("VisibleFor_id", "tableId", "recordId", "forAll", "forGroupId", "forAssocId", "encryptedCheck", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (919, 23, 75, 0, 0, 10, 'aakJA2Mgv19Dhim5t3Q3gQ1Kjvg8L981', 1164904874, 10, 0, 0, 0)
```

## Adding a company to a static selection

![x][img1]

```SQL
INSERT INTO CRM5."selectionmember" ("selectionmember_id", "selection_id", "contact_id", "person_id") VALUES (1776, 75, 19, 0)
```

> [!NOTE]
> `person_id = 0`

## Adding a person to a static selection

![x][img2]

```SQL
INSERT INTO CRM5."selectionmember" ("selectionmember_id", "selection_id", "contact_id", "person_id") VALUES (1774, 75, 13, 41)
```

<!-- Referenced images -->
[img1]: media/selection-addmembercontact.png
[img2]: media/screencap1.png
