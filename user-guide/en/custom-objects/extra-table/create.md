---
uid: help-en-blogic-listextratables-editextratable
title: blogic listExtraTables editExtraTable
description: blogic listExtraTables editExtraTable
author: SuperOffice RnD
so.date: 06.29.2022
keywords: extra table
so.topic: help
language: en
---

# Define extra tables

You can create extra tables in SuperOffice Service in order to register different types of data. Once the extra table has been defined and you have [created extra fields][1] in it, you can open the table to add content to it by going to ![icon][img3] **Requests** > **Tables**, point at the table and click ![icon][img1].

> [!NOTE]
> In SuperOffice CRM you can create web panels that can contain table information. To set the relevant access rights, the user must belong to a role that has the functional rights **List tables** and **Edit tables**.

To create an extra table:

1. Select ![icon][img2] **System settings** > **System design** > **Tables**.
2. Click ![icon][img4] **New table**. The **Table properties** screen appears.
3. In the **Table properties** screen, enter data about the new table:
    * **Folder**: If you want to place the table in an existing folder, select a folder from the list.
    * **Name**: The name of the table.
    * **Database table**: In this field, enter the name of the table in the database. You can only specify this name when the table is created; it cannot be changed later on. The table name may only contain underscores, the letters a to z or numbers, and the name must start with "y\_". A logical name is best, since it makes it easier to see what the database contains.
    * **Search header**: This is the header that is used in the search screen for this table.
    * **Header for viewing entry**: This is the header that is used when you display an entry in this table.
    * **Header for new entry**: This is the header that is used when you create a new entry in this table.
    * **Header for editing entry**: This is the header that is used when you edit an entry in this table.
    * **Sort order**: The default sort order for the table, i.e. which column the table will be sorted on. If you check **Descending**, the values are sorted in descending order. For numerical values, this means the highest value will appear at the top of the table. The table must contain fields before you can select anything here.
    * **Display field**: If data from this table is to be displayed in another table (a relation), you need to select here which field is to be displayed in the other table. The table must contain fields before you can select anything here.
    * **Parent field**: This field is used in connection with hierarchical tables.
    * **Full name**: If this is a hierarchical table, this field can specify a field that is automatically updated with the entry's full name based on the name field for this entry, and all parent entries.
    * **Hide ID field**: If this option is enabled, then the ID field will not be shown when listing entries in the table.
    * **Hide the table**: If you check this option, the table will not be visible from ![icon][img3] **Requests** > **Tables**.
4. Click **OK** to save the new table.

## What would you like to do now?

* [Define extra fields][1]

<!-- Referenced links -->
[1]: ../extra-field/create.md

<!-- Referenced images -->
[img1]: ../../../media/icons/btn-add.png
[img2]: ../../../media/icons/globalmenu-settings-small.png
[img3]: ../../../../common/icons/nav-cs.png
[img4]: ../../../media/icons/service/btn-newtable.png
