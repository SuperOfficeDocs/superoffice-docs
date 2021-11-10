---
title: Custom fields
uid: custom_fields
description: Custom fields
author: Bergfrid Dias
so.date: 11.05.2021
keywords: udef, API, user-defined field, UDefField, updatedCount, udefidentity
so.topic: concept
---

# Custom fields

[!include[License requirement](../includes/req-dev-tools.md)]

## What are Udef fields?

You are allowed to add your own fields to contact, project, person, sale, appointment, and documents tables. These fields are known as **user-defined** fields. In the application, user-defined fields are visible in the **More** tab.

> [!NOTE]
> Only an administrator can add a user-defined field. You can **update** the data stored in a user-defined field.

## UDefField table

User-defined fields use a layout described in a table called [UDefField][1].

One row in the `UDefField` table describes one field in one particular version of the layout. The same field can be described many times in the table, once for each layout that has been published.

Every time the admin publishes a new layout of fields, a new version of the layout is created. One row is added for each field being published. After the new layout is created, the values are shifted around if necessary.

This is the part of the publishing process that takes time.

```SQL
SELECT * FROM udeffield
ORDER BY ownerTable_id, updatedCount, version
```

This will show you how a field has changed over time.

The owner-table tells you where the field belongs (contact, person, project, sale)

The `updatedCount` is a unique ID for each field that does not change as the field is changed.

The version is updated every time a new layout is published. The current version number is stored in a user preference.

For most fields, you’ll see the same info repeated for each version. Sometimes a new field is added, sometimes the tab order will change slightly.

The travel system uses these old versions to handle travelers who return home after the layout has changed. Their changed data is mapped to the new layout when they return.

## Value tables

User-defined fields are stored in special database tables. For example, for contact, user-defined fields are stored in `udcontactsmall` and `udcontactlarge`. These 2 tables have lots of fields such as `long02` and `string04`, which barely describe their function to the user.

When the user-defined fields are defined for a contact, the system controls which field of `udcontactsmall` or `udcontactlarge` they are assigned. The `Udcontactsmall` table contains short fields such as int and floats, while the `udcontactlarge` table contains large text fields such as  `varchar[255]`.

* The **small** table contains integer values and short strings (10 chars)
* The **large** table contains long strings (200 chars max)

Some fields are indexed, some are not. The first 4 fields are indexed for searching:

* `long01`-`long04` (UdXxxSmall table)
* `string01`-`string04`
* `double01` – `double04`
* `string41`-`string44` (UdXxxLarge table)

The same structure applies to all the user-defined fields.

![UdXxxSmall and UdXxxLarge tables diagram][img2]

```SQL
SELECT userdef_id FROM project WHERE name='Client SDK Work'

SELECT * FROM udprojectsmall WHERE udprojectsmall_id = 2345
```

| udprojectSmall_id | long01 | long02 | long03 | long04 | long05 | ... |
|---|---|---|---|---|---|---|
211 | 0 | 0 | 0 | 0 | 0 | |

If you change a field from non-searchable to searchable, its values are moved from a non-indexed to indexed field when you publish the change. For example, from `long05` to `long01`

The only thing that has changed is that the new field is indexed. Unfortunately, we can’t just add an index on the table – we have to move the data into the indexed field.

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

```SQL
SELECT columnId, fieldLabel, fieldType, version, udefidentity
FROM udeffield
WHERE ownerTable_id = 9
ORDER BY udefidentity, version
```

| columnId | fieldLabel | fieldType | version | udefidentity |
|---|---|---|---|---|
| 36417 | projectshorttext | 2 | 2 | 1 |
| 36417 | projectshorttext | 2 | 3 | 1 |
| 36417 | projectshorttext | 2 | 4 | 1 |
| 36417 | projectshorttext | 2 | 5 | 1 |
| 36417 | projectshorttext | 2 | 6 | 1 |
| 36417 | projectshorttext | 2 | 7 | 1 |
| 36417 | projectshorttext | 2 | 8 | 1 |
| 36417 | projectshorttext | 2 | 9 | 1 |
| 36613 | projectlongtext | 3 | 2 | 2 |
| 36613 | projectlongtext | 3 | 3 | 2 |
| 36613 | projectlongtext | 3 | 4 | 2 |
| 36613 | projectlongtext | 3 | 5 | 2 |
| 36613 | projectlongtext | 3 | 6 | 2 |
| 36613 | projectlongtext | 3 | 7 | 2 |
| 36613 | projectlongtext | 3 | 8 | 2 |
| 36613 | projectlongtext | 3 | 9 | 2 |
| 36357 | projectnumber | 1 | 2 | 3 |
| 36357 | projectnumber | 1 | 3 | 3 |

`udefidentity` is a unique identifier for the field allocated by the udef system when a field is created. You can change the tab-order, the name of the field, or the type – the `udefidentity` remains the same.

This value used to be stored in updatedCount in SuperOffice.

The **column ID** is the dictionary ID of the table and field used for storing the value.

* 36358 = `UdProjSmall.Long06` (not indexed, not fast to search)
* 36353 = `UdProjSmall.Long01` (indexed field)

## Column offset

What is column offset? Column offset is the sequential place of the column in the table. This is a zero-based number. For example:

**This is a visual representation of a table:**

| Column 1 | Column 2 | Column 3 |
|---|---|---|
| Column Offset 0 | Column Offset 1 | Column Offset 2 |

Given this information, we can determine that the column identity values for the contact table are are follows:

**Contact table: ID = 5 (first 3 columns):**

| contact_id | name | kananame |
|---|---|---|
|1280<br>(column ID = table ID \* 256 + offset) | 1281 | 1282 |

## See also

* [udeffield table][1]
* [udcontactsmall table][2]
* [udpersonsmall table][3]
* [udprojectsmall table][4]
* [udsalesmall table][5]
* [uddocsmall table][6]
* [udappntsmall table][7]

<!-- Referenced links -->
[1]: ../../../database/docs/tables/udeffield.md
[2]: ../../../database/docs/tables/udcontactsmall.md
[3]: ../../../database/docs/tables/udpersonsmall.md
[4]: ../../../database/docs/tables/udprojectsmall.md
[5]: ../../../database/docs/tables/udsalesmall.md
[6]: ../../../database/docs/tables/uddocsmall.md
[7]: ../../../database/docs/tables/udappntsmall.md

<!-- Referenced images -->
[img2]: media/udef-diagram.png
