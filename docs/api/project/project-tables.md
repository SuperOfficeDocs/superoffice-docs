---
title: Project tables 
uid: project_db_tables
description: Project tables
author: {github-id}
keywords:
so.topic: concept
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Project tables

![Project card][img1]

The project record contains the name and IDs of some of the other items.

The **project type** comes from the `ProjType` table. The `Project` table contains a `type_idx` field which contains the foreign key of the ProjType record we want. The name and tooltip are stored in the `ProjType` table.

The **project status** is similar – the project table contains the foreign key in the `status_idx` field, and the actual name of the status is held in the `ProjStatus` table.

Both these fields are examples of [list items][1].

The text description is stored in the `Text` table. We have the `text_id` stored in the project record.

![Project tables][img2]

The Responsible field is showing us an employee’s person name. The employees are stored in the `Associate` table. The `Project` table has an `associate_id` field that we use to look up the associate record. The associate record refers to a Person record through its `person_id`.

The three fields below the `Responsible` field are all user-defined. The values are stored in a table called `UDProjectSmall`, while the labels and default values for these fields are stored in a table called `UdefField`.

There is a field called "Web site" which can contain zero or more web addresses. There is no URL field in the project record, but there is a table called `URL` which contains a many-to-one relation through its `project_id` field.

The relations are one-to-one mostly. At this level, the database structure isn’t very complicated.

> [!NOTE]
> The name in the Associate table is not the full name – it's the login name, the user name. The full name is stored in the person record.

So putting together a project display is just a matter of reading the right record, and then following the relations arrows out to the right tables.

<!-- Referenced links -->
[1]: ../lists/mdo-lists.md

<!-- Referenced images -->
[img1]: media/so-project.gif
[img2]: media/so-project-tables.gif
