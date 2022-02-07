---
uid: crmscript_custom_db
title: Database customizations
description: There are 3 ways to customize the database schema - user-defined fields; extra fields; extra tables
author: Bergfrid Dias
so.date: 10.27.2021
keywords:
so.topic: concept
---

# Database customizations

[!include[License requirement](../includes/req-dev-tools.md)]

## Why data-driven data

In the SuperOffice application, we can have custom fields. When we have a set of fields that is constantly changing, we will face a problem with returning these fields in our web service methods because we cannot change web service methods when someone defines a new field. To avoid this situation, SuperOffice has introduced the concept of data-driven data in the NetServer.

In NetServer all the user-defined fields have been packed into a single property of entity by using a string dictionary. If we take the `contact` entity, it will have a property called `UserDefinedFields` which represents all the user-defined fields. In the context of the `contact` entity, this property will house all the user-defined fields of the contact entity as key-value pairs.

## Ways to customize

There are 3 ways to customize the database schema:

* [user-defined fields][1] in Sales
* [extra fields][2] on SuperOffice entities in Service
* [extra tables][3] (aka 3rd party tables) in Service

[!include[License requirement](../includes/req-dev-tools.md)]

## User-defined fields vs. extra fields

SuperOffice CRM and Service were once 2 separate applications, with different extensibility.
User-defined fields (udefs for short) belong in SuperOFfice CRM, while extra tables and extra fields belong in Service.

| Customization      | Managed from   | Visible in  | Limit | Stored in |
|:-------------------|:---------------|:------------|:------|:----------|
| user-defined field | CRM<br>the **Fields** screen | **More** tab of entity | max 119 per entity | UDXXXsmall or UDXXXlarge per entity|
| extra field        | Service<br>the **Tables** screen | **Extra fields** tab of entity | no | database table of entity (table.x_field) |

> [!NOTE]
> You will **not** see user-defined fields in Service, and reversely, you will not see extra fields in CRM. Unless you develop custom screens or web panels, that is. (With some configuration, you can also add extra fields to the **Details** tab.)

## Requirements

* SuperOffice Expander Services license
* SuperOffice 8.1 or newer
* NetServer must be restarted every time you change the schema
  * If Travel is activated, a new Travel database must also be generated

> [!NOTE]
> [Continuous Database (CD)][4] is available onsite only.

## API support

You can't customize the database schema via the APIs. It's on the roadmap, but for now, you must do this in the SuperOffice Service UI. After setting it up, you can manage the data in them via the APIs.

<!-- Referenced links -->
[1]: udef/index.md
[2]: extra-field/index.md
[3]: extra-table/index.md
[4]: ../database/dictionary/index.md
