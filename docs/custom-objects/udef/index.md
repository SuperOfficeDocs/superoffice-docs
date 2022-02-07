---
uid: udef
title: User-defined fields explained
author: Bergfrid Dias
so.date: 02.07.2022
keywords: udef, custom objects, custom fields, user-defined field, UDefField, updatedCount, udefidentity
so.topic: concept
---

# User-defined fields

A *user-defined* field (udef) is a custom field that you add to an existing SuperOffice database table. You can extend the following entities:

* company
* contact
* documents
* follow-up
* project
* sale

There are 8 different types of user-defined fields: Number, Decimal, Short text, Long text, Date, Unlimited date, Checkbox, and List (drop-down).

User-defined fields are managed in the SuperOffice CRM Admin client, in the **Fields** screen.

[!include[License requirement](../../includes/req-dev-tools.md)]

## Storage

| Field type       | Database table | Data type   |
|:-----------------|:---------------|:------------|
| Number           | UDXXXsmall     | Long        |
| Decimal          | UDXXXsmall     | Double      |
| Short text       | UDXXXsmall     | String[40]  |
| Long text        | **UDXXXLarge** | String[200] |
| Date             | UDXXXsmall     | Long        |
| Unlimited date   | UDXXXsmall     | String[40]  |
| Checkbox         | UDXXXsmall     | Long        |
| List (drop-down) | UDXXXsmall     | Long        |

### Available fields by type

Each entity that supports user-defined fields can have up to **119 custom fields**.

| Data type   | Quantity | Used by                          |
|:------------|:---------|:---------------------------------|
| Long        | 60       | number, date, check-box and list |
| Double      | 10       | decimal                          |
| String[40]  | 40       | short text and unlimited date    |
| String[200] | 9        | long text                        |

> [!NOTE]
> When all String[40] fields are taken, the system will use String[200] from the corresponding `UDXXXLarge` table. This will decrease the available number of fields for the long text type fields.

## Indexed fields

Indexing is good for user experience and performance. The first 4 fields of each data type are reserved for indexes.

You have to mark the checkbox when creating the field to allow it to be indexed. You can mark up to 4 fields in each of the 4 data types (Long, Double String[40], String[200]) for each entity. For example, you can index 4 numbers and 4 decimals for a contact, however you can't at the same time also index a date - because all Long index slots are taken by the numbers.

If you choose not to index at all, you're essentially wasting 16 fields! Thus, the max number of custom fields is reduced to 103.

## Prog IDs

The prog ID is used to identify user-defined fields for an entity. The format is **text:number**.

By default, the text part is *SuperOffice* and the number is a running counter. You can customize the ID when you create the field, but keep the text portion to letters a-z or their uppercase equivalents.

## Dates

User-defined *date* fields use the **SuperDate** format. This is a string:

* a set of square brackets enclosing a prefix and the date itself
* D: (fixed)
* the date on the YYYY.MM.DD format

For example, "[D:2020.08.27]".

## Creating user-defined fields

1. Sign in to the SuperOffice CRM Admin client and select **Fields** in the main menu.
2. Select the entity you want to extend and then click **Add**.
3. Enter a name and select a type.
4. Optionally set other field properties, such as whether it is mandatory or should be indexed.
5. Click **Save**.
6. Optionally adjust the layout and/or set the field to be shown on the first page of the selected screen.
7. Continue adding fields. Click **Publish** when you're done.

> [!TIP]
> You can select up to 3 fields that will be included on the main card.

## Convert field type

Not all conversions are possible because different types of user-defined field values are stored in different tables in the database and use different base data types.

1. Go to the **Fields** screen.
2. Select the entity and then double-click the field you want to change.
3. Use the drop-down to set choose a new type. You'll see only the compatible field types.
4. Click **Save**. Then click **Publish**.

| Field type     | Number | Decimal | Short text | Long text | Date | Unlimited date | Checkbox | List |
|:---------------|:------:|:-------:|:----------:|:---------:|:----:|:--------------:|:--------:|:----:|
| Number         | x      | x       | x          |           |      |                |          |      |
| Decimal        | x      | x       | x          |           |      |                |          |      |
| Short text     | x      |         | x          |           |      |                |          |      |
| Long text      |        |         |            | x         |      |                |          |      |
| Date           |        |         | x          |           | x    | x              |          |      |
| Unlimited date |        |         | x          |           |      | x              |          |      |
| Checkbox       |        |         | x          |           |      |                | x        |      |
| List           |        |         | x          |           |      |                |          | x    |

**How to read the table:**

The field types in the left column are compatible with and can be converted to the types marked with an x.
For example, a number can be converted to a decimal and a short text. (And it's obviously compatible with itself.)

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
[1]: ../../database/tables/udeffield.md
[2]: ../../database/tables/udcontactsmall.md
[3]: ../../database/tables/udpersonsmall.md
[4]: ../../database/tables/udprojectsmall.md
[5]: ../../database/tables/udsalesmall.md
[6]: ../../database/tables/uddocsmall.md
[7]: ../../database/tables/udappntsmall.md

<!-- Referenced images -->
[img2]: media/udef-diagram.png
