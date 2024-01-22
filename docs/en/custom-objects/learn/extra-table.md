---
uid: help-en-extra-table
title: Third-party tables
descripotion: Introduction to SuperOffice extra tables
author: Bergfrid Dias
so.date: 01.16.2024
keywords: database, extra table, custom object
so.topic: concept
language: en
so.audience: user
so.audience.tooltip: SuperOffice CRM
---

# Third-party tables

[!include[License requirement](../../../../common/includes/req-dev-tools.md)]

SuperOffice Development Tools license gives you the possibility to create extra tables in the database. Instantly, these third-party tables will be available for standard CRUD operations in SuperOffice Service. You need to set up a web panel to access them from the Sales client.

The **Tables** screen is your tool for customizing the database schema.

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

<!-- Referenced links -->
[1]: ../../ui/blogic/learn/index.md
[2]: ../admin/create-extra-table.md
[3]: ../admin/create-extra-field.md
[4]: ../admin/add-udef.md

<!-- Referenced images -->
