---
title: MDO lists
uid: mdo_lists
description: Multi-Department Organisation (MDO) lists
author:
so.date:
keywords: filtering, mdo
so.topic: concept
---

# Multi-Department Organisation (MDO) lists

Larger organizations may need to hide non-relevant information from employees. This is now possible with the multi-department organization (hereafter referred to as MDO) lists.

To take templates as an example, this means that, if MDO is implemented in SuperOffice, a user will see only those templates, with a record in `TemplateGroupLink` pointing to the UserGroup the user is a member of.

The templates will be grouped with headings taken from the `Heading` table, and under each heading will be the templates that have a `TemplateHeadingLink` record pointing both to the template and the `Heading`. This means that a single template may appear several times in the list, under several headings.

## Relations

Each primary list table will have two link tables related to MDO functionality: one for filtering and one for grouping.

The `Heading` table contains the headings to be used in the MDO list boxes, for all lists.

The `Link` table between a list and the `Heading` table is always named `<list table name>HeadingLink`.

The `UserGroup` table is treated in a special way. It has no direct `Link` tables and is instead used by Link tables as a target to implement the MDO filtering.

An associate is a member of only one `UserGroup`, as specified in the associate record. MDO filtering will be implemented by showing records from the **other** lists if, and only if, they have entries in the `<list table name>GroupLink`.

The following diagram illustrates the new structure:

![x][img1]

## Table ordering

To make coding simpler, the List tables are defined in a specific order so that the table ID of the Link tables can be calculated from the main table ID. The order is:

| ID | Description |
|---|---|
| ID = k   |Main table, for instance, Template |
| ID = k+1 |GUI Group link, in this case, TemplateHeadingLink |
| ID = k+2 |Filter link, in this case, TemplateGroupLink |

## Example

### Filter without heading

```SQL
SELECT l.category_id, l.name FROM Category l, CategoryGroupLink gl, UserGroupLink ugl
WHERE l.deleted = 0 AND l.category_id = gl.category_id AND gl.group_id = ugl.usergroup_id AND ugl.assoc_id = <my assoc_id>;
```

The result is a set of list names, filtered via the user's group membership. Items that the user is not allowed to see will not be returned.

> [!NOTE]
> Because a user may be a member of more than one usergroup we have to join against the [UserGroupLink][1] table.<br>Items that are visible to more than one group will be returned twice. Use `SELECT DISTINCT` to filter the duplicates out.

<!-- Referenced links -->
[1]: ../../../../database/docs/tables/usergrouplink.md

<!-- Referenced images -->
[img1]: media/mdo-grouplinks.gif
