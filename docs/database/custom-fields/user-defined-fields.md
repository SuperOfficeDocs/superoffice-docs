---
title: udef
description: User-defined fields
author:
so.date:
keywords:
so.topic: concept
---

# User-defined fields

User-defined fields use a layout described in a table called `UDefField`.

One row in the `UDefField` table describes one field in one particular version of the layout. The same field can be described many times in the table, once for each layout that has been published.

Every time the admin publishes a new layout of fields, a new version of the layout is created. One row is added for each field being published. After the new layout is created, the values are shifted around if necessary.

This is the part of the publishing process that takes time.

```sql
SELECT * FROM udeffield
ORDER BY ownerTable_id, updatedCount, version
```

This will show you how a field has changed over time.

The owner-table tells you where the field belongs (contact, person, project, sale)

The `updatedCount` is a unique ID for each field that does not change as the field is changed.

The version is updated every time a new layout is published. The current version number is stored in a user-preference.

For most fields, you’ll see the same info repeated for each version. Sometimes a new field is added, sometimes the tab-order will change slightly.

The travel system uses these old versions to handle travelers who return home after the layout has changed. Their changed data is mapped to the new layout when they return.

## Column IDs

```sql
SELECT columnId, fieldLabel, fieldType, version, udefidentity
FROM udeffield
WHERE ownerTable_id = 9
ORDER BY udefidentity, version
```

![x][img1]

`udefidentity` is a unique identifier for the field allocated by the udef system when a field is created.  You can change the tab-order, the name of the field or the type – the `udefidentity` remains the same.

This value used to be stored in updatedCount in CRM 5.

The **column ID** is the dictionary ID of the table and field used for storing the value.

* 36358 = `UdProjSmall.Long06` (not indexed --&gt; not fast to search)
* 36353 = `UdProjSmall.Long01` (indexed field)

## Value tables

The values are stored in two tables: `UDProjectSmall` and `UDProjectLarge`

* The **small** table contains integer values and short strings (10 chars)
* The **large** table contains long strings (200 chars max)

Some fields are indexed, some are not. The first 4 fields are indexed for searching:

* `long01`-`long04` (UdXxxSmall table)
* `string01`-`string04`
* `double01` – `double04`
* `string41`-`string44` (UdXxxLarge table)

The same structure applies to all the user-defined fields.

![x][img2]

```sql
SELECT userdef_id FROM project WHERE name='Client SDK Work'

SELECT * FROM udprojectsmall WHERE udprojectsmall_id = 2345
```

![x][img3]

If you change a field from non-searchable to searchable, its values are moved from a non-indexed to indexed field when you publish the change. For example, from `long05` to `long01`

The only thing that has changed is that the new field is indexed. Unfortunately we can’t just add an index on the table – we have to move the data into the indexed field.

## See also

* [udeffield Table][1]
* [udcontactsmall Table][2]
* [udpersonsmall Table][3]
* [udprojectsmall Table][4]
* [udsalesmall Table][5]
* [uddocsmall Table][6]
* [udappntsmall Table][7]

<!-- Referenced links -->
[1]: ../tables/udeffield.md
[2]: ../tables/udcontactsmall.md
[3]: ../tables/udpersonsmall.md
[4]: ../tables/udprojectsmall.md
[5]: ../tables/udsalesmall.md
[6]: ../tables/uddocsmall.md
[7]: ../tables/udappntsmall.md

<!-- Referenced images -->
[img1]: media/udef-field.png
[img2]: media/udef-diagram.png
[img3]: media/udprojectsmall.png
