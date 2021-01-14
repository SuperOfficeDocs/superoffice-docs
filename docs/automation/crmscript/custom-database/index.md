---
title: Database customizations
uid: crmscript_custom_db
SortOrder: 40
---

## Ways to customize

There are 3 ways to customize the database schema:

* [user-defined fields](./udef.md) in Sales
* [extra fields](./extra-fields.md) on SuperOffice entities in Service
* [extra tables](./extra-tables.md) (aka 3rd party tables) in Service

## User-defined fields vs. extra fields

SuperOffice CRM and Service were once to 2 separate applications, with different extensibility.
User-defined fields (udefs for short) belong in SuperOFfice CRM, while extra tables and extra fields belong in Service.

| Customization      | Managed from   | Visible in  | Limit | Stored in |
|:-------------------|:---------------|:------------|:------|:----------|
| user-defined field | CRM<br />the **Fields** screen | **More** tab of entity | max 119 per entity | UDXXXsmall or UDXXXlarge per entity|
| extra field        | Service<br />the **Tables** screen | **Extra fields** tab of entity | no | database table of entity (table.x_field) |

> [!NOTE]
> You will **not** see user-defined fields in Service, and reversely, you will not see extra fields in CRM. Unless you develop custom screens or web panels, that is. (With some configuration, you can also add extra fields to the **Details** tab.)

## Requirements

* SuperOffice Expander Services license
* SuperOffice 8.1 or newer
* NetServer must be restarted every time you change the schema
  * If Travel is activated, a new Travel database must also be generated

> [!NOTE]
> [Continuous Database (CD)](https://community.superoffice.com/en/content/.content/database/continuous-database/) is available onsite only.

## API support

You can't customize the database schema via the APIs. It's on the road-map, but for now, you must do this in the SuperOffice Service UI. After setting it up, you can manage the data in them via the APIs.
