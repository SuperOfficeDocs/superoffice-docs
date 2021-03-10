---
title: custom_fields       
description: Custom fields
author: {github-id}             # Your GitHub alias.
keywords: udef
so.topic: concept
---

# Custom fields

## What are Udef fields?

You are allowed to add your own fields to contact, project, person, sale, appointment, and documents tables. These fields are known as user-defined fields. In the application, user-defined fields are visible in the corresponding main cards.

> [!NOTE]
> Only an administrator can add a user-defined field. You can **update** the data stored in a user-defined field.

User-defined fields are stored in special database tables. For example, for contact, user-defined fields are stored in `udcontactsmall` and `udcontactlarge`. These 2 tables have lots of fields such as `long02` and `string04`, which barely describe their function to the user.

When the user-defined fields are defined for a contact, the system controls which field of `udcontactsmall` or `udcontactlarge` they are assigned. The `Udcontactsmall` table contains short fields such as int and floats, while the `udcontactlarge` table contains large text fields such as  `varchar[255]`.

## Table identity

Every table can be identified by an integer value. For example:

* company = 1
* associate = 2
* associategrouplink = 3
* associateheadinglink = 4
* contact = 5
* ...
* licencesatllink = 239
* productversion = 240

## Column identity

Every column in a table is identified by an integer value. That value is derived by the following computation:

* Column identity = table identity \* 256 + column offset

What is column offset? Column offset is the sequential place of the column in the table. This is zero-based number. For example:

**This is a visual representation of a table:**

| Column 1 | Column 2 | Column 3 |
|---|---|---|
| Column Offset 0 | Column Offset 1 | Column Offset 2 |

Given this information, we can determine that the column identity values for the contact table are are follows:

**Contact table: ID = 5 (first 3 columns):**

| contact\_id | name | kananame |
|---|---|---|
|1280<br>(column ID = table ID \* 256 + offset) | 1281 | 1282 |
