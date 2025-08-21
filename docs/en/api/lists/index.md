---
title: List
description: Overview of general lists and Multi-departmental organizational (MDO) lists.
author: AnthonyYates
date: 03.03.2022
keywords: Lists, 
content_type: concept
redirect_from: /en/api/netserver/lists/index
---

# Lists

This section will focus on the many lists that the NetServer provides to make our lives easy. Here we will discuss: what these lists are, how we can use them, the most important list interfaces, and finally some examples of how we can use these lists.

## Overview of lists

When developing applications, it is necessary to provide lists so that the users can be allowed to select items with ease.

In NetServer a list is a set of data presented as an object that can be directly bound to any control which supports lists. The advantage is that we do not have to construct the list, all we have to do is call a NetServer method, and then we can get the list made exactly the way it is created and managed in SuperOffice administration. This saves us a lot of time and we don’t have to do the complex things that involve building up a list like this all by ourselves.

### Options

* Web services:
  * [Managing lists][1]

## Introduction to Multi-Department Organisation (MDO) lists

Larger organizations may need to hide non-relevant information from employees. This is now possible with the multi-department organization (hereafter referred to as MDO) lists.

To take templates as an example, this means that, if MDO is implemented in SuperOffice, a user will see only those templates, with a record in `TemplateGroupLink` pointing to the UserGroup the user is a member of.

The templates will be grouped with headings taken from the `Heading` table, and under each heading will be the templates that have a `TemplateHeadingLink` record pointing both to the template and the `Heading`. This means that a single template may appear several times in the list, under several headings.

### Relations

Each primary list table will have two link tables related to MDO functionality: one for filtering and one for grouping.

The `Heading` table contains the headings to be used in the MDO list boxes, for all lists.

The `Link` table between a list and the `Heading` table is always named `{list-table-name}HeadingLink`.

The `UserGroup` table is treated in a special way. It has no direct `Link` tables and is instead used by Link tables as a target to implement the MDO filtering.

An associate is a member of only one `UserGroup`, as specified in the associate record. MDO filtering will be implemented by showing records from the **other** lists if, and only if, they have entries in the `<list table name>GroupLink`.

The following diagram illustrates the new structure:

![x][img1]

### Table ordering

To make coding simpler, the List tables are defined in a specific order so that the table ID of the Link tables can be calculated from the main table ID. The order is:

| ID | Description |
|---|---|
| ID = k   |Main table, for instance, Template |
| ID = k+1 |GUI Group link, in this case, TemplateHeadingLink |
| ID = k+2 |Filter link, in this case, TemplateGroupLink |

### SQL Example - for context

#### Filter without heading

```SQL
SELECT l.category_id, l.name FROM Category l, CategoryGroupLink gl, UserGroupLink ugl
WHERE l.deleted = 0 AND l.category_id = gl.category_id AND gl.group_id = ugl.usergroup_id AND ugl.assoc_id = <my assoc_id>;
```

The result is a set of list names, filtered via the user's group membership. Items that the user is not allowed to see will not be returned.

> [!NOTE]
> Because a user may be a member of more than one usergroup we have to join against the [UserGroupLink][2] table.
>
> Items that are visible to more than one group will be returned twice. Use `SELECT DISTINCT` to filter the duplicates out.

<!-- Referenced links -->
[1]: services/index.md
[2]: ../../database/tables/usergrouplink.md

<!-- Referenced images -->
[img1]: media/mdo-grouplinks.gif
