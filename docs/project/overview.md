---
title: Projects
uid: project-overview
description: Working with projects
author: Bergfrid Dias
so.date: 04.02.2022
keywords: project, project management, SQL, API, ProjType, type_idx, ProjStatus, status_idx
so.topic: concept
# so.envir:
# so.client:
---

# Projects

[!include[License requirement](../../common/includes/req-for-project-mgt.md)]

![Project card -screenshot][img1]

A project typically consists of different stages. For each stage, you have certain activities and perhaps documents that need to be completed. With every activity and every stage completed, you will get closer to completing the project.

## Key info

* a unique ID
* a name
* a project manager or owner
* project members
* the type of project
* a status
* milestones
* an (expected) end date

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

## Howtos

* [Using CRMScript][3]
* [Using raq SQL][2]

## Projects vs. other entities

When working with projects, data will often intersect with the following entities:

* [company][14] (contact table)
* [contact][15] (person table)
* [documents][12]
* [follow-ups][13] (appointment table)
* [sales][16]

<!-- Referenced links -->
[1]: ../api/lists/index.md
[2]: howto/sql/index.md
[3]: howto/crmscript/index.md
[5]: ../database/tables/project.md
[6]: ../database/tables/projtype.md
[7]: ../database/tables/projstatus.md
[8]: ../database/tables/associate.md
[9]: ../database/tables/udprojectsmall.md
[10]: ../database/tables/udprojectlarge.md
[11]: ../database/tables/udeffield.md
[12]: ../document/index.yml
[13]: ../diary/index.yml
[14]: ../company/index.yml
[15]: ../contact/index.yml
[16]: ../sale/index.yml

<!-- Referenced images -->
[img1]: media/project.png
[img2]: media/so-project-tables.gif
