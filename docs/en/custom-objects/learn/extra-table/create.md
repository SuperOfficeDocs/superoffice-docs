---
uid: help-en-extra-table-create
title:  Define extra tables
description:  Define extra tables
author: Hanne Gunnarsson
so.date: 03.29.2023
keywords: extra table
so.topic: howto
so.user: admin
so.user.tooltip: Settings and maintenance
language: en
---

# Add extra tables

You can create extra tables in SuperOffice to register different types of data. After you create the table and [create extra fields][1] in it, you can open the table to add content to it by going to **System design** > **Tables**, point at the table and click the button ![icon][img1].

> [!NOTE]
> In SuperOffice you can create web panels that can contain table information. To set the relevant access rights, the user must belong to a role that has the functional rights **List tables** and **Edit tables**.

**Steps:**

1. Go to the **Tables** screen.

    * In Settings and maintenance: Click the ![icon][img3] **System design** button in the navigator. Then select the **Tables** tab.

2. Click the button ![icon][img4]. The **Table properties** screen appears.

3. In the **Table properties** screen, enter data about the new table. Se details about the fields below.

4. Click **OK** to save the new table.

## Fields

| Field | Description |
|---|---|
| Folder | To place the table in an existing folder, select a folder from the list. |
| Name | The name of the table. |
| Database table   The name of the database table. Can be specified only at creation and cannot be changed. The table name may contain underscores, the letters a-z, and numbers only, and the name must start with "y_". A logical name is best, because it makes it easier to see what the database contains. |
| Search header | The header used in the search screen for this table. |
| Header for viewing entry | The header used when you display an entry in this table. |
| Header for new entry | The header used when you create a new entry in this table. |
| Header for editing entry | The header used when you edit an entry in this table. |
| Sort order | The column the table is sorted on. If you check **Descending**, the values are sorted in descending order. For numerical values, this means the highest value will appear at the top of the table. The table must contain fields before you can select anything here. |
| Display field | If data from this table is displayed in another table (a relation), you must select which field to display in the other table. The table must contain fields before you can select anything here. |
| Parent field | This field is used in connection with hierarchical tables. |
| Full name |  If this is a hierarchical table, this field can specify a field that is automatically updated with the entry's full name based on the name field for this entry, and all parent entries. |
| Hide ID field | If this option is enabled, then the ID field will not be shown when listing entries in the table. |
| Hide the table | If checked, the table will not be visible from ![icon][img3] **System design** > **Tables**. |

## What would you like to do now?

* [Define extra fields][1]

<!-- Referenced links -->
[1]: ../extra-field/create.md

<!-- Referenced images -->
[img1]: ../../../../media/icons/service/new-field.png
[img3]: ../../../../../common/icons/nav-admin-systemdesign-active.png
[img4]: ../../../../media/icons/service/new-table.png
