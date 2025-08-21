---
uid: project-create-sql
title: Add project
description: How to add and examine projects in API with raw SQL.
keywords: project, SQL, API, project_number
author: Bergfrid Dias
date: 05.31.2023
content_type: howto
redirect_from:
  - /en/project/howto/sql/create
  - /en/api/netserver/sql/howto/project/create
---

# Adding a project

When you register a project in SuperOffice, quite a bit happens behind the scenes.

Create a new project called *Client SDK Work* and save it. (Click on the **New** button and fill in the name, then click **OK**.) You may be required to fill in several required fields, depending on the database you are using.

Use your favorite query tool and try this query:

```SQL
SELECT * FROM project WHERE name = 'client sdk work'
```

You should get one line back in the result window.

The SuperOffice client has done quite a bit of work for us: it has added records to three different tables:

* [project][1]
* [text][2]
* transaction log

It may also have indexed the name and description text into a free-text index – this depends on your setup.

It has generated unique numbers for us (not just `record_id` numbers) and put these numbers into specific fields in the project record (`project_number` field in this case).

It has updated a transaction log to allow synchronizing remote databases.

It has generated a soundex value based on the project’s `name` field. This value is used for detecting duplicates.

 | Project name | Soundex value |
 |---|---|
 | Client SDK Work | KLNTSTKAR |
 | Klient SDK –woork | KLNTSTKAR |

It has timestamped and marked the record with the creator. You can see this in the registered and `registered_associate` fields.

<!-- Referenced links -->
[1]: ../../../../database/tables/project.md
[2]: ../../../../database/tables/text.md
