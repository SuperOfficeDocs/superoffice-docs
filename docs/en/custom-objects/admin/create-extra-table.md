---
uid: help-en-extra-table-create
title:  Add extra table
description: How to define extra tables in SuperOffice
keywords: extra table, custom object, 3rd-party table, System design
author: Bergfrid Dias
date: 01.18.2024
version: 10
content_type: howto
audience: settings
audience_tooltip: Settings and maintenance
language: en
redirect_from: /en/custom-objects/learn/extra-table/create
index: true
---

# Add extra table

You can create extra database tables to register different types of data in SuperOffice. After you create the table and [add extra fields][1] to it, you can open the table to add content.

## Steps

1. [!include[Go to tables](includes/goto-tables.md)]

1. Click **New table**.

    ![Create extra table -screenshot][img1]

1. In the **Table properties** screen, enter data about the new table.

    * Enter a *name* to be used as the label.
    * Enter a *database table* beginning with **y_** to identify it in the schema.
    * Optionally set other properties. Se details about the fields below.

    > [!NOTE]
    > Some table properties cannot be set until you have added fields.

1. Click **OK** to save the new table (runs `create table y_mynewtable ...`).

1. [Add fields to your new table][1].

1. Optionally, adjust table properties such as sort order. (Click the table name in the list to enter edit mode.)

1. Click **Restart NetServer**. If Travel is activated, you will also see a message that a new Travel database must be generated.

You can now open the table in the UI to add content to it **or** populate it via the APIs.

## Table properties

| Property | Description |
|---|---|
| Folder | To place the table in an existing folder, select a folder from the list. |
| Name | The UI label of the table. |
| Database table | The database table's name can only be set during creation and **cannot be changed**. It should start with "y_", and can only include underscores, letters (a-z), and numbers. A logical name is recommended for easy identification of the database content. |
| Search header | The header used in the search screen for this table. |
| Header for viewing entry | The header used when you display an entry in this table. |
| Header for new entry | The header used when you create a new entry in this table. |
| Header for editing entry | The header used when you edit an entry in this table. |
| Sort order | The column the table is sorted on. If you check **Descending**, the values are sorted in descending order. For numerical values, this means the highest value will appear at the top of the table. The table must contain fields before you can select anything here. |
| Display field | When data from this table is shown in another (related) table, you need to choose the field to display in that table. The table must contain fields before you can select anything here. |
| Parent field | Used in connection with hierarchical tables. |
| Full name |  If this is a hierarchical table, this field can specify a field that is automatically updated with the entry's full name based on the name field for this entry, and all parent entries. |
| Hide ID field | If selected, the ID field will not be shown when listing entries in the table. |
| Hide the table | If selected, the table will not be visible from **System design** > **Tables**. |

## Show table in a web panel

In SuperOffice you can create web panels that can contain table information. To set the relevant access rights, the user must belong to a role that has the functional rights **List tables** and **Edit tables**.

<!-- Referenced links -->
[1]: create-extra-field.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/custom-objects/create-extra-tables-and-fields.png
