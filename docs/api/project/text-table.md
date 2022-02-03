---
title: Text table
uid: text_db_table
description: Text table
author: Bergfrid Dias
so.date: 11.05.2021
keywords: project, project management, SQL, API, text_id, owner_id
so.topic: concept
# so.envir:
# so.client:
---

# Text table

The description and note is stored in the `text` table. We have the `text_id` stored in the project record.

**To find the text description for a project:**

```SQL
SELECT * FROM text WHERE text_id = 1234
```

Replace the value 1234 with the `text_id` of your project.

If you get back a blank result, it is because you did not type a description when entering the project in the client.

If you get back more than one row it is because there may be several different records (project records, contact records, appointments) with the same record ID. The `type_id` field on the text record tells us whom the text record belongs to.

## Type and owner ID

> [!NOTE]
> The text record has a type and an `owner_id`. The type values are described in the [text table reference][1].

Some of the values used are:

* 6 = project description
* 11 = project post-it text

This mechanism (of having type and owner IDs) is used multiple places in the database. The advantage is that it is very flexible since new tables can have text added to them just by defining a new type ID to use in the text table.

The downside is that the joins become more complex since you need to specify both the type and the `owner_id` when joining with the `text` table. Another downside is that this mechanism is impossible to define cleanly with referential integrity constraints.

You can add a project post-it text if you click on the **Note** button in the middle of the toolbar at the bottom of the SuperOffice client screen. This will attach a yellow note to the card.

The text you type into the note also goes into the text table, with the same `owner_id`, but with a different type ID.

<!-- Referenced links -->
[1]: ../../../database/docs/tables/text.md
