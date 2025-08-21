---
uid: project-howto-sql
title: Project SQL howto
description: Working with projects in raw SQL.
keywords: project, project management, API, SQL, ProjType, type_idx, ProjStatus, status_idx
author: Bergfrid Skaara Dias
date: 05.31.2023
content_type: howto
redirect_from:
  - /en/project/howto/sql/index
  - /en/api/netserver/sql/howto/project/index
---

# Howto

[!include[License requirement](../../../../../../common/includes/req-for-project-mgt.md)]

The [project table][5] contains the name and IDs of some of the other items.

![project table relationship diagram][img2]

The relations are one-to-one mostly. At this level, the database structure is not very complicated. So putting together a project display is just a matter of reading the right record, and then following the relations arrows out to the right tables.

<!-- TBD include Relations table from ../../../database/tables/project.md?range=69-90 -->

## Project type

The **project type** comes from the [ProjType][6] table. The `project` table contains a `type_idx` field, which contains the foreign key of the ProjType record we want. The name and tooltip are stored in the `ProjType` table.

To find the project type:

```SQL
SELECT * FROM projtype WHERE projtype_id = 1234
```

Replace 1234 with the `type_idx` in your project.

Here, we get one record with a text and a tooltip description. The tooltip is displayed when you hover the mouse over the text, and when you are editing the record.

## Project status

The **project status** is similar – the project table contains the foreign key in the `status_idx` field, and the actual name of the status is held in the [ProjStatus][7] table.

Both type and status fields are examples of [list items][4].

## Project manager/owner

The **employees** are stored in the [associate][8] table. The `project` table has an `associate_id` field that we use to look up the associate record. The associate record refers to a person record through its `person_id`.

> [!NOTE]
> The name in the `associate` table is not the full name – it's the login name, the user name. The full name is stored in the person record.

## Custom fields

Any **user-defined field** values are stored in [udprojectSmall][9] or [udprojectLarge][10], while the labels and default values for these fields are stored in a table called [UdefField][11].

## URL records

The UI field called **Website** can contain zero or more web addresses. There is no URL field in the project record, but there is a table called `URL` that contains a many-to-one relation through its `project_id` field.

If you want to put together a list of the URLs that belong to this project, the SQL is this:

```SQL
SELECT * FROM url WHERE project_id = 1234 ORDER BY rank
```

There may be several URLs all referencing the same `project_id`. This is OK. The URLs will be presented in rank order. The first rank will always be 1.

## Sample queries

* [Create project][1]
* [Project guides][2]
* [Project description][3]

<!-- Referenced links -->
[1]: create.md
[2]: project-guide.md
[3]: text-table.md
[4]: ../../../lists/index.md
[5]: ../../../../database/tables/project.md
[6]: ../../../../database/tables/projtype.md
[7]: ../../../../database/tables/projstatus.md
[8]: ../../../../database/tables/associate.md
[9]: ../../../../database/tables/udprojectsmall.md
[10]: ../../../../database/tables/udprojectlarge.md
[11]: ../../../../database/tables/udeffield.md

<!-- Referenced images -->
[img2]: ../../../../database/tables/media/project.png
