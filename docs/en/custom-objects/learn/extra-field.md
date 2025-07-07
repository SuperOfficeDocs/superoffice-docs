---
uid: help-en-extra-field
title: Extra fields
description: An extra field is a custom field that you add to an existing SuperOffice database table in Service.
keywords: extra field, custom field, field types
author: Bergfrid Dias
date: 06.11.2024
version: 10.3.7
content_type: concept
language: en
audience: person
audience_tooltip: SuperOffice CRM
redirect_from: /en/custom-objects/extra-field/index
---

# Extra fields

[!include[License requirement](../../includes/req-dev-tools.md)]

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

## <a id="field-types"></a>Field types

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

### <a id="relation"></a>Relations (foreign keys)

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

#### Available in pilot from version 10.3.4

When a relational field is set to display one-to-many relations, the system automatically adds a section tab in related standard entities. This is not the same as the **Relations** tab in the Company and Contact screens.

![Section tab with extra field relation -screenshot][img1]

#### Available in pilot from version 10.3.7

To view the details of items in this list, without having to open each individual entity:

1. Go to the side panel and select the **Preview** view.
2. Click an item in the relation-based section tab. The side panel displays a preview of the selected entity. In the preview, you can:

    * Click a standard entity to go to go to it.
    * Click a custom objet to open a dialog for viewing or editing additional information.

![Preview extra field relation -screenshot][img2]

## Usage

Extra fields can for instance be used as search criteria and columns in sales in SuperOffice CRM.

## Related content

* [Show extra fields on the Details tab][1]
* [Create extra field][2]

<!-- Referenced links -->
[1]: ../admin/show-extra-field-on-request-details.md
[2]: ../admin/create-extra-field.md
[6]: extra-table.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/automation/section-tab-for-relation.png
[img2]: ../../../media/loc/en/automation/preview-custom-object-from-side-panel.png
