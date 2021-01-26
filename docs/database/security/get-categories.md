---
uid: exampleGetListOfCategories
title: Get List Of Categories
---

# Get all categories

```SQL
select l.category_id, l.name, l.tooltip from Category l where l.deleted = 0 order by l.rank
```

The result is a list of categories, ordered by rank in the list.

The deleted items are not included, but items that should be hidden from the user because of MDO filtering are included.

![x][img1]

## Filter without heading

Filtering means that items that are hidden from the user should not be shown.

Filtering is done through the user's group membership.

Some items are hidden from some groups.

```SQL
select l.category_id, l.name, l.rank from Category l, CategoryGroupLink gl, UserGroupLink ugl
  where l.deleted = 0
  and l.category_id = gl.category_id
  and gl.group_id = ugl.usergroup_id
  and ugl.assoc_id = <my assoc_id>;
  order by l.rank
```

The result is a set of list names, filtered via the user's group membership. Items that the user is not allowed to see will not be returned.

> [!NOTE]
> A user may be a member of more than one usergroup, and we therefore have to join against the [UserGroupLink][1] table.<br>Iems that are visible to more than one group will be returned twice. Use SELECT DISTINCT to filter the duplicates out.

![x][img1]

## Get all items with headings, no filtering

```SQL
select h.rank, h.name, l.name, l.category_id, l.rank from Heading h, Category l, CategoryHeadingLink hl
  where l.deleted = 0
  and h.heading_id = hl.heading_id
  and l.category_id = hl.category_id
  order by h.rank, l.rank
```

The result is a set of heading-name pairs, ordered by heading and then the desired order within each heading.

> [!NOTE]
> An item may appear under multiple headings - this allowed by the list admin tool.

![x][img3]

## Filter and group under headings

```SQL
select distinct h.rank, h.name, l.name, l.category_id, l.rank
  |from Heading h, Category l, CategoryHeadingLink hl, CategoryGroupLink gl, UserGroupLink ugl
  |where l.deleted = 0
  |and h.heading_id = hl.heading_id
  |and l.category_id = hl.category_id
  |and l.category_id = gl.category_id
  |and gl.group_id = ugl.usergroup_id
  |and ugl.assoc_id = **&lt;my assoc_id&gt;**
  |order by h.rank, l.rank
```

This will give the correctly filtered set of names from the list, ordered by headings and rank.

List items that are hidden from the user will be removed from the result by the database using the `UserGroupLink` join.

<!-- Referenced links -->
[1]: ../tables/usergrouplink.md

<!-- Referenced images -->
[img1]: media/select-category-1.gif
[img2]: media/select-category-2.gif
[img3]: media/select-category-3.gif
