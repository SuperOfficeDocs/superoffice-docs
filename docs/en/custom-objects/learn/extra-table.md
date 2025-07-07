---
uid: help-en-extra-table
title: Third-party tables
description: Introduction to SuperOffice extra tables
keywords: database, extra table, custom object, 3rd-party table
author: Bergfrid Dias
date: 08.27.2024
version: 10.3.8
content_type: concept
language: en
audience: person
audience_tooltip: SuperOffice CRM
redirect_from:
  - /en/custom-objects/extra-table/index
  - /en/custom-objects/learn/extra-table/index
---

# Third-party tables

[!include[License requirement](../../includes/req-dev-tools.md)]

SuperOffice Development Tools license gives you the possibility to create extra tables (custom objects) in the database.

The **Tables** screen is your tool for customizing the database schema.

## How to access

<!-- markdownlint-disable MD051 -->
### [Classic](#tab/extra-table-old)

Third-party tables are instantly available for standard CRUD operations in SuperOffice Service. You need to set up a web panel to access them from the Sales client.

### [New (from version 10.3.4 pilot)](#tab/extra-table-new)

No longer confined to SuperOffice Service, you can effortlessly explore and maintain data in extra tables from SuperOffice CRM.

#### Build dashboards using custom objects

![Dashboard with custom objects -screenshot][img1]

#### Find and selection

**Custom object as search criteria for company, contact, sale, project, request, activity:**

![Custom object as search criteria -screenshot][img2]

**Create selection of custom objects (10.3.7):**

![Find screen with custom objects -screenshot][img3]

![Selection of custom objects -screenshot][img4]

#### Maintaining data (10.3.7)

**Open Custom Objects overview:**

![Custom Objects overview -screenshot][img5]

**Search:**

![Custom Objects overview, search -screenshot][img6]

**Preview:**

![Custom Objects overview, preview -screenshot][img7]

**Add/remove items:**

When viewing the results for a specific item in the **Custom Objects** overview, click the **Task** button and select **New** or **Delete**.

**Pre-fill fields when loading custom object (10.3.8):**

The new [SalesLoadCustomObject][6] trigger is called before a custom object screen is loaded. Use it to set default values in fields and define business rules.

***
<!-- markdownlint-restore -->

## Tables screen

The **Tables** screen shows a list of database tables. It displays both standard tables (predefined in the system and form the basis of different screens) and extra tables (tables you create yourself with optional content).

Here, you can create new tables and fields for different screens and dialogs. Only administrators have access to this functionality.

### Table folders

Table folders are used to organize your custom tables.

## Conventions

> [!CAUTION]
> Choose your database table and field names carefully. They cannot be changed later!
>
> A logical name is best because it makes it easier to see what the database contains.

Prefixes ensure that what you create do not conflict with future SuperOffice table and field names. However, it does not guarantee a lack of naming conflicts between different 3rd parties.

### Table names

* Must start with **y_**
* May contain only underscores, the letters a to z, and numbers

### Field names

* Must start with **x_**
* Must be unique within the table
* Must be a single word
* May contain only underscores, letters from a to z, and numbers

## Related topics

* [Add extra table][2]
* [Add extra fields][3]
* [Add user-defined fields][4]
* [Custom screens][1]
* [Create trigger][5]

<!-- Referenced links -->
[1]: ../../ui/blogic/learn/index.md
[2]: ../admin/create-extra-table.md
[3]: ../admin/create-extra-field.md
[4]: ../admin/add-udef.md
[5]: ../../../en/automation/trigger/create-trigger-script.md
[6]: ../../../en/automation/trigger/reference/CRMScript.Event.Trigger.yml#CRMScript_Event_Trigger_SalesLoadCustomObject

<!-- Referenced images -->
[img1]: ../../../media/loc/en/automation/custom-object-dashboard.png
[img2]: ../../../media/loc/en/automation/find-custom-object-relation.png
[img3]: ../../../media/loc/en/automation/find-screen-with-custom-objects.png
[img4]: ../../../media/loc/en/automation/custom-object-selection.png
[img5]: ../../../media/loc/en/automation/go-to-custom-objects.png
[img6]: ../../../media/loc/en/automation/search-inventory.png
[img7]: ../../../media/loc/en/automation/preview-inventory-results.png
