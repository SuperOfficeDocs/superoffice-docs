---
uid: crmscript_custom_db
title: Database customizations
description: There are 3 ways to customize the database schema - user-defined fields; extra fields; extra tables
author: Bergfrid Dias
so.date: 10.27.2021
keywords:
so.topic: concept
---

# Custom objects

[!include[License requirement](../../../common/includes/req-dev-tools.md)]

## Data-driven approach

In the SuperOffice application, we can have custom fields. When we have a set of fields that is constantly changing, we will face a problem with returning these fields in our web service methods because we cannot change web service methods when someone defines a new field. To avoid this situation, SuperOffice has introduced the concept of data-driven data in the NetServer.

In NetServer all the user-defined fields have been packed into a single property of entity by using a string dictionary. If we take the `contact` entity, it will have a property called `UserDefinedFields` which represents all the user-defined fields. In the context of the `contact` entity, this property will house all the user-defined fields of the contact entity as key-value pairs.

## Ways to customize

There are 3 ways to customize the database schema:

* [user-defined fields][1] in Sales
* [extra fields][2] on SuperOffice entities in Service
* [extra tables][3] (aka 3rd party tables) in Service

The remainder of this document only details custom fields. To read more about custom tables, please following the [extra tables][3] link.

## Custom Fields

SuperOffice CRM and Service were once 2 separate applications, with different custom field extensibility options. When discussed today, custom fields represent both user-defined fields and extra fields, and is therefore considered best practice to be explicit about which one is the focus when discussed.

User-defined fields (udefs for short) belong in SuperOffice CRM, while extra tables and extra fields belong in Service.

Each CRM entity allows user-defined fields: appointment, contact, document, person, project, sale, however only CRM contact and person allow extra fields.

| Customization      | Managed from   | Visible in  | Limit | Stored in |
|:-------------------|:---------------|:------------|:------|:----------|
| user-defined field | CRM<br>the **Fields** screen | **More** tab of entity | max 119 per entity | UDXXXsmall or UDXXXlarge per entity|
| extra field        | Service<br>the **Tables** screen | **Extra fields** tab of entity | no | database table of entity (table.x_field) |

> [!NOTE]
> You will **not** see user-defined fields in Service, and reversely, you will not see extra fields in CRM. Unless you develop custom screens or web panels, that is. (With some configuration, you can also add extra fields to the **Details** tab.)

## API support

It's only possible to create and manage user-defined fields via the APIs, however extra fields and tables must be managed in the SuperOffice Service UI. All custom object data is accessible via the APIs.

### Viewing Entity Data

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

### Searching custom fields

Using custom fields in [search queries][5] are prefixed by their entity and type, i.e. contactUdef/SuperOffice:1 or personUdef/SuperOffice:1.

**User defined fields** as listed in the SimpleContact archive provider docs:

|prefix/progId              |datatype     |description                               | can orderby |
|---------------------------|-------------|------------------------------------------|--|
|contactUdef/SuperOffice:1  |string       |companyshorttext: tooltipshorttext        | x|
|contactUdef/SuperOffice:2  |string       |companylongtext: tooltiplongtext          | x|
|contactUdef/SuperOffice:3  |int          |companynumber                             | x|
|contactUdef/SuperOffice:4  |date         |companydate                               | x|
|contactUdef/SuperOffice:5  |unlimitedDate|companyunlimiteddate: tooltipunlimiteddate| x|
|contactUdef/SuperOffice:6  |bool         |companycheckbox                           | x|
|contactUdef/SuperOffice:7  |listAny      |companydropdownlistbox                    | x|
|contactUdef/SuperOffice:8  |decimal      |companydecimal                            | x|
|contactUdef/SuperOffice:9  |string       |page1saleonly                             | x|
|contactUdef/SuperOffice:10 |string       |page1marketingonly                        | x|
|contactUdef/SuperOffice:11 |string       |page1adminonly                            | x|
|contactUdef/SuperOffice:12 |listAny      |Udlist one: Static tooltip for udlist one | x|
|contactUdef/SuperOffice:13 |listAny      |Udlist two: Static tooltip for udlist two | x|

**Extra fields** are not currently included in the archive provider documentation. They are declared and accessed by the enity and type prefix, followed by a forward slash and the field name.

|prefix/x_fieldName          |datatype  |description                               |
|----------------------------|----------|------------------------------------------|
|contactExtra/x_fieldName    |[various] |Used to select contact extra fields. |
|personExtra/x_fieldName     |[various] |Used to select person extra fields. |
|ejCategoryExtra/x_fieldName |[various] |Used to select ejCategory extra fields. |
|ejUserExtra/x_fieldName     |[various] |Used to select ejUser extra fields. |
|extra/x_fieldName           |[various] |Used to select ticket extra fields. |

> [!NOTE]
> Extra field archive query support is only available for:
>
> * contact
> * person
> * ejCategory
> * ejUser
> * ticket

## Requirements

* SuperOffice Expander Services license
* SuperOffice 8.1 or newer
* NetServer must be restarted every time you change the schema
  * If Travel is activated, a new Travel database must also be generated

> [!NOTE]
> [Continuous Database (CD)][4] is available onsite only.

<!-- Referenced links -->
[1]: udef/index.md
[2]: extra-field/index.md
[3]: extra-table/index.md
[4]: ../database/dictionary/index.md
[5]: ../api/search/index.md
