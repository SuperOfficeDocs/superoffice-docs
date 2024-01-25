---
uid: help-en-extra-field
title: Extra fields
description: An extra field is a custom field that you add to an existing SuperOffice database table in Service.
author: Bergfrid Dias
so.date: 01.16.2024
so.version: 10
keywords: extra field, custom field, Service
so.topic: concept
language: en
so.audience: user
so.audience.tooltip: SuperOffice CRM
---

# Extra fields

[!include[License requirement](../../../../common/includes/req-dev-tools.md)]

An *extra field* is a custom field that you add to an existing SuperOffice database table. You can extend the following entities:

* Category
* Company
* Contact
* FAQ category and entry
* Message
* Request
* User
* Your [custom tables][6]

> [!NOTE]
> Extra fields on company or contact are not the same as user-defined fields on those entities!

Extra fields are managed in **Settings and maintenance**, in the **Tables** screen.

## <a id="field-types" />Field types

* Bool (yes/no)
* Integer
* Float
* Text (short)
* Text (long)
* Date
* Date and time
* Time
* Timespan
* Attachment
* Dynamic link

In addition, each entity has a relation type. For example, the *contact relation*.

Unlike user-defined fields, extra fields are added as actual fields to the database tables. There are no pre-defined slots you need to take into consideration, and essentially no limitations.

### Relations (foreign keys)

Database tables are connected with *foreign keys* (FK). These are the field types ending in *relation*.

* Contact relation
* Company relation
* User relation
* Request relation
* Category relation
* Priority relation
* FAQ relation
* Sale relation
* Project relation
* Appointment relation
* Extra table relation

## Usage

Extra fields can for instance be used as search criteria and columns in sales in SuperOffice CRM.

## Related content

* [Show extra fields on the Details tab][1]
* [Create extra field][2]

<!-- Referenced links -->
[1]: ../admin/show-extra-field-on-request-details.md
[2]: ../admin/create-extra-field.md
[6]: extra-table.md
