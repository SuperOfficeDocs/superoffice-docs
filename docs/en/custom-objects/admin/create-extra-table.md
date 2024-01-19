---
uid: help-en-extra-table-create
title:  Add extra table
description: How to define extra tables in SuperOffice
author: Bergfrid Dias
so.date: 01.18.2024
keywords: extra table, custom object
so.topic: howto
so.audience: settings
so.audience.tooltip: Settings and maintenance
language: en
---

# Add extra table

You can create extra tables in SuperOffice to register different types of data. After you create the table and [create extra fields][1] in it, you can open the table to add content to it.

## Steps

1. [!include[Go to tables](../includes/goto-tables.md)]

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

1. Optionally adjust table properties such as sort order.
    * Click the table name in the list to enter edit mode.

1. Click **Restart NetServer**. If Travel is activated, you will also see a message that a new Travel database must be generated.

You can now open the table in the UI to add content to it **or** populate it via the APIs.

## Table properties

| Property | Description |
|---|---|
| Folder | To place the table in an existing folder, select a folder from the list. |
| Name | The name of the table (label). |
| Database table | The name of the database table. Can be specified only at creation and **cannot be changed**. The table name may contain underscores, the letters a-z, and numbers only, and the name must start with "y_". A logical name is best, because it makes it easier to see what the database contains. |
| Search header | The header used in the search screen for this table. |
| Header for viewing entry | The header used when you display an entry in this table. |
| Header for new entry | The header used when you create a new entry in this table. |
| Header for editing entry | The header used when you edit an entry in this table. |
| Sort order | The column the table is sorted on. If you check **Descending**, the values are sorted in descending order. For numerical values, this means the highest value will appear at the top of the table. The table must contain fields before you can select anything here. |
| Display field | If data from this table is displayed in another table (a relation), you must select which field to display in the other table. The table must contain fields before you can select anything here. |
| Parent field | This field is used in connection with hierarchical tables. |
| Full name |  If this is a hierarchical table, this field can specify a field that is automatically updated with the entry's full name based on the name field for this entry, and all parent entries. |
| Hide ID field | If selected, the ID field will not be shown when listing entries in the table. |
| Hide the table | If selected, the table will not be visible from **System design** > **Tables**. |

## Show table in a web panel

In SuperOffice you can create web panels that can contain table information. To set the relevant access rights, the user must belong to a role that has the functional rights **List tables** and **Edit tables**.

## What would you like to do now?

* [Add fields to the new table][1]

<!-- Referenced links -->
[1]: create-extra-field.md

<!-- Referenced images -->
[img1]: ../../../media/loc/en/custom-objects/create-extra-tables-and-fields.png
