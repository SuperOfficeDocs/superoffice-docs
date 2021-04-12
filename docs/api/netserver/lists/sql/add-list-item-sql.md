---
title: add_list_item_sql
description: Adding a list item
author:
so.date:
keywords: 
so.topic: howto
---

# Adding a list item

Adding a list item to a list requires 2, possibly 3, possibly 4 things:

1. Insert the list-item into the item table (e.g. Category).
2. Insert Group-link items into the group-link table (for example, `CategoryGL`).
    You need to insert one link item per group. If you do not, then the MDO security system will filter your item out.
3. Optional: Insert a heading item in the heading table.
4. Optional: Insert one or more heading-link items into the heading-link table (e.g. CategoryHL).

We edit lists in the SuperOffice Admin client. Here we add a new category item to the category list:

![x][img1]

![x][img2]

## Insert the category item

```SQL
INSERT INTO CRM."category" ("Category_id", "name", "rank", "tooltip", "deleted", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (11, 'Fresh Category', 11, 'A fresh new category of companies.', 0, 1164907192, 11, 0, 0, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110585, 1164910792, 0, 4352, 11, 64, 11)
```

## Make the category item visible for the usergroups

```SQL
INSERT INTO CRM."categorygrouplink" ("categorygrouplink_id", "category_id", "group_id", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (41, 11, 1, 1164907192, 11, 0, 0, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110586, 1164910792, 0, 4352, 11, 65, 41)

INSERT INTO CRM."categorygrouplink" ("categorygrouplink_id", "category_id", "group_id", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (42, 11, 2, 1164907192, 11, 0, 0, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110587, 1164910792, 0, 4352, 11, 65, 42)

INSERT INTO CRM."categorygrouplink" ("categorygrouplink_id", "category_id", "group_id", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (43, 11, 3, 1164907192, 11, 0, 0, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110588, 1164910792, 0, 4352, 11, 65, 43)

INSERT INTO CRM."categorygrouplink" ("categorygrouplink_id", "category_id", "group_id", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (44, 11, 4, 1164907192, 11, 0, 0, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110589, 1164910792, 0, 4352, 11, 65, 44)

INSERT INTO CRM."categorygrouplink" ("categorygrouplink_id", "category_id", "group_id", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (45, 11, 5, 1164907192, 11, 0, 0, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110590, 1164910792, 0, 4352, 11, 65, 45)

INSERT INTO CRM."categorygrouplink" ("categorygrouplink_id", "category_id", "group_id", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (46, 11, 6, 1164907192, 11, 0, 0, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110591, 1164910792, 0, 4352, 11, 65, 46)

INSERT INTO CRM."categorygrouplink" ("categorygrouplink_id", "category_id", "group_id", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (47, 11, 7, 1164907192, 11, 0, 0, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110592, 1164910792, 0, 4352, 11, 65, 47)
```

## Place the category item under a heading

```SQL
INSERT INTO CRM."categoryheadinglink" ("categoryheadinglink_id", "category_id", "heading_id", "registered", "registered_associate_id", "updated", "updated_associate_id", "updatedCount") VALUES (11, 11, 6, 1164907569, 11, 0, 0, 0)

INSERT INTO CRM."traveltransactionlog" ("traveltransactionlog_id", "ttime", "prev_record_id", "type", "associate_id", "tablenumber", "record_id") VALUES (110593, 1164911169, 0, 4352, 11, 66, 11)
```

<!-- Referenced images -->
[img1]: media/screencap2.png
[img2]: media/edit-list-item.png
