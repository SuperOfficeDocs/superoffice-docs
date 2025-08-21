---
uid: get-catlist-sql
title: Get list of categories
description: How to get all categories with raw SQL.
keywords: category, CategoryGroupLink, contact
author: Bergfrid Dias
date: 02.21.2022
content_type: howto
redirect_from:
  - /en/company/howto/sql/get-catlist-sql
  - /en/api/netserver/sql/howto/company/get-catlist-sql
---

# Get all categories

```SQL
SELECT l.category_id, l.name, l.tooltip FROM Category l WHERE l.deleted = 0 ORDER BY l.rank
```

The result is a list of categories, ordered by rank in the list.

The deleted items are not included, but items that should be hidden from the user because of MDO filtering are included.

| category_id | name | tooltip |
|---|---|---|
| 754 | Customer A | Big fish |
| 755 | Customer B | Dinner-sized fish |
| 756 | Customer C | Small fish |
| 318 | Partner customer | |
| 732 | International customer | |
| 317 | Former customer | Has license, but no maintenance agreement |

## Filter without heading

Filtering means that items that are hidden from the user should not be shown.

Filtering is done through the user's group membership.

Some items are hidden from some groups.

```SQL
SELECT l.category_id, l.name, l.rank FROM Category l, CategoryGroupLink gl, UserGroupLink ugl
  WHERE l.deleted = 0
  AND l.category_id = gl.category_id
  AND gl.group_id = ugl.usergroup_id
  AND ugl.assoc_id = <my assoc_id>;
  ORDER BY l.rank
```

The result is a set of list names, filtered via the user's group membership. Items that the user is not allowed to see will not be returned.

> [!NOTE]
> Because a user may be a member of more than one usergroup, we have to join against the [UserGroupLink][1] table.
>
> Items that are visible to more than one group will be returned twice. Use SELECT DISTINCT to filter the duplicates out.

| category_id | name | rank |
|---|---|---|
| 754 | Customer A | 1 |
| 755 | Customer B | 2 |
| 756 | Customer C | 3 |
| 732 | International customer | 10|
| 317 | Former customer | 13 |
| 104 | Partner | 14 |
| 416 | Business partner | 16 |
| 455 | Partner under certification | 17 |

## Get all items with headings, no filtering

```SQL
SELECT h.rank, h.name, l.name, l.category_id, l.rank FROM Heading h, Category l, CategoryHeadingLink hl
  WHERE l.deleted = 0
  AND h.heading_id = hl.heading_id
  AND l.category_id = hl.category_id
  ORDER BY h.rank, l.rank
```

The result is a set of heading-name pairs, ordered by heading and then the desired order within each heading.

> [!NOTE]
> An item may appear under multiple headings - this is allowed by the list admin tool.

| rank | name | name | category_id | rank |
|---|---|---|---|---|
| 1 | Other | Intern  | 392 | 99 |
| 1 | Other | Employee | 13 | 100 |
| 1 | Other | Supplier | 4 | 101|
| 1 | Other | Competitor | 588 | 105 |
| 2 | Partner | Partner | 104 | 14 |
| 2 | Partner | Business partner | 416 | 16 |
| 2 | Partner | Partner under certification | 455 | 17 |
| 2 | Partner | SAP vendor | 918 | 18 |
| 2 | Partner | Potential partner | 18 | 19 |

## Filter and group under headings

```SQL
SELECT DISTINCT h.rank, h.name, l.name, l.category_id, l.rank
  FROM Heading h, Category l, CategoryHeadingLink hl, CategoryGroupLink gl, UserGroupLink ugl
  WHERE l.deleted = 0
  AND selecth.heading_id = hl.heading_id
  AND l.category_id = hl.category_id
  AND l.category_id = gl.category_id
  AND gl.group_id = ugl.usergroup_id
  AND ugl.assoc_id = <my assoc_id>
  ORDER BY h.rank, l.rank
```

This will give the correctly filtered set of names from the list, ordered by headings and rank.

List items that are hidden from the user will be removed from the result by the database using the `UserGroupLink` join.

<!-- Referenced links -->
[1]: ../../../../database/tables/usergrouplink.md

<!-- Referenced images -->
