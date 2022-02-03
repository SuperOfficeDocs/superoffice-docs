---
title: Projects
uid: api_project
description: Working with projects in API with raw SQL.
author: Bergfrid Dias
so.date: 11.05.2021
keywords: project, project management, SQL, API, ProjType, type_idx, ProjStatus, status_idx
so.topic: concept
# so.envir:
# so.client:
---

# Projects

> [!NOTE]
> Project management requires either a Sales Premium, Service Premium, or Marketing license. For details, see the [list of user plans][12].

![Project card -screenshot][img1]

The [project table][5] contains the name and IDs of some of the other items.

![Diagram of project related tables][img2]

The relations are one-to-one mostly. At this level, the database structure isn’t very complicated. So putting together a project display is just a matter of reading the right record, and then following the relations arrows out to the right tables.

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

Both type and status fields are examples of [list items][1].

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

## More info

* [How to create a project][4]
* [Project guides][3]
* [Description and notes][2]

<!-- Referenced links -->
[1]: ../netserver/lists/mdo-lists.md
[2]: text-table.md
[3]: project-guide.md
[4]: create-project.md
[5]: ../../../database/docs/tables/project.md
[6]: ../../../database/docs/tables/projtype.md
[7]: ../../../database/docs/tables/projstatus.md
[8]: ../../../database/docs/tables/associate.md
[9]: ../../../database/docs/tables/udprojectsmall.md
[10]: ../../../database/docs/tables/udprojectlarge.md
[11]: ../../../database/docs/tables/udeffield.md
[12]: ../../../superoffice-docs/docs/license/user-plans.md

<!-- Referenced images -->
[img1]: media/project.png
[img2]: media/so-project-tables.gif
