---
title: Add project
uid: add_project
description: Adding a project
author: Bergfrid Dias
so.date: 10.27.2021
keywords: project, project management
so.topic: howto
# so.envir:
# so.client:
---

# Adding a project

When you register a project in SuperOffice, quite a bit happens behind the scenes.

> [!NOTE]
> Project management requires either a Sales Premium, Service Premium, or Marketing license. For details, see the [list of user plans][7].

Create a new project called *Client SDK Work* and save it. (Click on the **New** button and fill in the name, then click **OK**.)

You may be required to fill in several required fields, depending on the database you are using.

![Registering a new Project][img1]

Use your favorite query tool and try this query:

```SQL
 SELECT * FROM project WHERE name = 'client sdk work'
```

You should get one line back in the result window.

The SuperOffice client has done quite a bit of work for us: it has added records to four different tables:

* Project
* Text
* UDProjectSmall
* transaction log

It may also have indexed the name and description text into a free-text index – this depends on your setup.

It has generated unique numbers for us (not just `record_id` numbers) and put these numbers into specific fields in the project record ( `project_number` field in this case)

It has updated a transaction log to allow synchronizing remote databases. We’ll see more about this in a bit.

It has generated a soundex value based on the project’s `name` field. This value is used for detecting duplicates.

 | Project name | Soundex value |
 |---|---|
 | Client SDK Work   | KLNTSTKAR |
 | Klient SDK –woork | KLNTSTKAR |

It has timestamped and marked the record with the creator. You can see this in the registered and `registered_associate` fields.

The tables are described in more detail here:

* [Project tables][1]
* [Guided project][2]
* [Project type and URLs][3]
* [Text table][4]

<!-- Referenced links -->
[1]: project-tables.md
[2]: project-guide.md
[3]: project-type-and-url.md
[4]: text-table.md
[7]: ../../../superoffice-docs/docs/license/user-plans.md

<!-- Referenced images -->

[img1]: media/so-project.gif
