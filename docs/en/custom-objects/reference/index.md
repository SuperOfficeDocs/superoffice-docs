---
uid: custom-objects-reference
title: Database customizations
description: There are 3 ways to customize the database schema - user-defined fields; extra fields; extra tables
author: Bergfrid Dias
date: 01.18.2024
version: 10
keywords: custom object, custom field, udef, extra table, extra field, user-defined field, UDefField, updatedCount, udefidentity
topic: reference
audience: api
audience_tooltip: SuperOffice APIs and database
redirect_from: /en/custom-objects/overview
index: true
---

# Working with custom objects and fields in API

[!include[License requirement](../../includes/req-dev-tools.md)]

Via the APIs, it is possible to create and manage user-defined fields only. Extra fields and tables must be managed in Settings and maintenance. However, all custom object data is accessible via the APIs.

## Data-driven approach

In the SuperOffice application, we can have custom fields. When we have a set of fields that is constantly changing, we will face a problem with returning these fields in our web service methods because we cannot change web service methods when someone defines a new field. To avoid this situation, SuperOffice has introduced the concept of data-driven data in the NetServer.

In NetServer all the user-defined fields have been packed into a single property of entity by using a string dictionary. If we take the `contact` entity, it will have a property called `UserDefinedFields` which represents all the user-defined fields. In the context of the `contact` entity, this property will house all the user-defined fields of the contact entity as key-value pairs.

## Ways to customize

There are 3 ways to customize the database schema:

* [User-defined fields (udef)][1] in Sales
* [Extra fields][2] on SuperOffice entities in Service
* [Extra tables][3] (aka 3rd party tables) in Service

SuperOffice CRM and Service were once 2 separate applications, with different custom field extensibility options. When discussed today, custom fields represent both user-defined fields and extra fields, and is therefore considered best practice to be explicit about which one is the focus when discussed.

User-defined fields belong in SuperOffice CRM, while extra tables and extra fields belong in Service. You will **not** see user-defined fields in Service, and reversely, you will not see extra fields in CRM. Unless you develop custom screens or web panels, that is. (With some configuration, you can also add extra fields to the **Details** tab.)

| Customization | Managed from | Visible in | Limit | Stored in |
|:--|:--|:--|:--|:--|
| User-defined field | CRM<br>the **Fields** screen | **More** tab of entity | max 119 per entity | UDXXXsmall or UDXXXlarge per entity|
| Extra field | Service<br>the **Tables** screen | **Extra fields** tab of entity | no | database table of entity (table.x_field) |

Each CRM entity allows user-defined fields: appointment, contact, document, person, project, sale, however only CRM contact and person allow extra fields.

## User-defined fields (udef)

### Storage

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

#### Dates

User-defined *date* fields use the **SuperDate** format. This is a string:

* a set of square brackets enclosing a prefix and the date itself
* D: (fixed)
* the date on the YYYY.MM.DD format

For example, "[D:2020.08.27]".

### Available fields by type

Each entity that supports user-defined fields can have up to **119 custom fields**.

| Data type   | Quantity | Used by |
|:------------|:---------|:--|
| Long        | 60       | number, date, check-box and list |
| Double      | 10       | decimal |
| String[40]  | 40       | short text and unlimited date |
| String[200] | 9        | long text |

> [!NOTE]
> When all String[40] fields are taken, the system will use String[200] from the corresponding `UDXXXLarge` table. This will decrease the available number of fields for the long text type fields.

### UDefField table

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

### Value tables

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
| 211 | 0 | 0 | 0 | 0 | 0 | |

If you change a field from non-searchable to searchable, its values are moved from a non-indexed to indexed field when you publish the change. For example, from `long05` to `long01`

The only thing that has changed is that the new field is indexed. Unfortunately, we can’t just add an index on the table – we have to move the data into the indexed field.

### Table identity

Every table can be identified by an integer value. For example:

* company = 1
* associate = 2
* associategrouplink = 3
* associateheadinglink = 4
* contact = 5
* ...
* licencesatllink = 239
* productversion = 240

### Column identity

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

### Column offset

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

## Viewing entity data

Custom objects in entity data are exposed as UserDefinedFields, ExtraFields, and CustomFields. CustomFields combines both UserDefinedFields and ExtraFields, and eventually the only means to access custom fields.

```json
"UserDefinedFields": {
    "SuperOffice:1": "[I:23]",
    "SuperOffice:1:DisplayText": "",
    "SuperOffice:1:DisplayTooltip": "",
  },
  "ExtraFields": {
    "x_hassupportagreement": "[I:0]",
  },
  "CustomFields": {
    "x_hassupportagreement": "[I:0]",
    "x_hassupportagreement:org": "[I:0]",
    "SuperOffice:1": "[I:0]",
    "SuperOffice:1:org": "[I:0]",
    "SuperOffice:1:DisplayText": "",
    "SuperOffice:1:DisplayTooltip": ""
  },
```

## Extra fields

## Storage

Unlike user-defined fields, extra fields are added as actual fields to the database tables. There are no pre-defined slots you need to take into consideration, and essentially no limitations.

If you add a field with database name `x_field` to the `ticket` table, the value will be stored in 1 of these 2 places:

* If it's an FK, the actual value is stored in a related table. `ticket.x_field` holds only the reference
* Otherwise, the value is stored in `ticket.x_field`

### The extra_fields table

| Property           | Description                               |
|:-------------------|:------------------------------------------|
| id                 | ID (PK)                                   |
| name               | UI label                                  |
| field_name         | the database name of the field            |
| type               | of field                                  |
| domain             | which table the field belongs to          |
| extra_table        | reference to the extra table the field belongs to, or -1 |
| target_extra_table | FK to an extra table                      |
| params             | various parameters for the field (string) |

For a complete list of properties, see the [database reference][18].

## Searching custom fields

Using custom fields in [search queries][5] are prefixed by their entity and type: contactUdef/SuperOffice:1 or personUdef/SuperOffice:1.

**User defined fields** as listed in the SimpleContact archive provider docs:

| prefix/progId | datatype | description | can orderby |
|---|---|---|---|
| contactUdef/SuperOffice:1 | string | companyshorttext: tooltipshorttext | x |
| contactUdef/SuperOffice:2 | string | companylongtext: tooltiplongtext | x |
| contactUdef/SuperOffice:3 | int | companynumber | x |
| contactUdef/SuperOffice:4 | date | companydate | x |
| contactUdef/SuperOffice:5 | unlimitedDate| companyunlimiteddate: tooltipunlimiteddate | x |
| contactUdef/SuperOffice:6 | bool | companycheckbox | x |
| contactUdef/SuperOffice:7 | listAny | companydropdownlistbox | x |
| contactUdef/SuperOffice:8 | decimal | companydecimal | x |
| contactUdef/SuperOffice:9 | string | page1saleonly | x |
| contactUdef/SuperOffice:10 | string | page1marketingonly | x |
| contactUdef/SuperOffice:11 | string | page1adminonly | x |
| contactUdef/SuperOffice:12 | listAny | Udlist one: Static tooltip for udlist one | x |
| contactUdef/SuperOffice:13 | listAny | Udlist two: Static tooltip for udlist two | x |

The **prog ID** is used to identify user-defined fields for an entity. The format is `text:number`. By default, the text part is *SuperOffice* and the number is a running counter. You can customize the ID when you create the field, but keep the text portion to letters a-z or their uppercase equivalents.

**Extra fields** are not currently included in the archive provider documentation. They are declared and accessed by the enity and type prefix, followed by a forward slash and the field name.

| prefix/x_fieldName | datatype | description |
|---|---|---|
| contactExtra/x_fieldName | [various] | Used to select contact extra fields. |
| personExtra/x_fieldName | [various] | Used to select person extra fields. |
| ejCategoryExtra/x_fieldName | [various] | Used to select ejCategory extra fields. |
| ejUserExtra/x_fieldName | [various] | Used to select ejUser extra fields. |
| extra/x_fieldName | [various] | Used to select ticket extra fields. |

> [!NOTE]
> Extra field archive query support is available only for:
>
> * contact
> * person
> * ejCategory
> * ejUser
> * ticket

## Requirements

* Development Tools license
* SuperOffice 8.1 or newer
* NetServer must be restarted every time you change the schema
  * If Travel is activated, a new Travel database must also be generated

> [!NOTE]
> [Continuous Database (CD)][10] is available onsite only.

## See also

* [udeffield table][11]
* [udcontactsmall table][12]
* [udpersonsmall table][13]
* [udprojectsmall table][14]
* [udsalesmall table][15]
* [uddocsmall table][16]
* [udappntsmall table][17]

<!-- Referenced links -->
[1]: ../learn/udef.md
[2]: ../learn/extra-field.md
[3]: ../learn/extra-table.md
[5]: ../../api/search/index.md
[10]: ../../database/dictionary/index.md
[11]: ../../database/tables/udeffield.md
[12]: ../../database/tables/udcontactsmall.md
[13]: ../../database/tables/udpersonsmall.md
[14]: ../../database/tables/udprojectsmall.md
[15]: ../../database/tables/udsalesmall.md
[16]: ../../database/tables/uddocsmall.md
[17]: ../../database/tables/udappntsmall.md
[18]: ../../database/tables/extra-fields.md

<!-- Referenced images -->
[img2]: media/udef-diagram.png
