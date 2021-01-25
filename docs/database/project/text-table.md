---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: text_db_table       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Text table # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Text table

Let’s find these records in the database.

```sql
SELECT * FROM project WHERE name = 'client sdk work'
```

We need to make a note of the values in the field: `project_id`.

## Text record

Now let us find the text description for this project:

```SQL
SELECT * FROM text WHERE text_id = 1234
```

Replace the value 1234  with the `text_id` you recorded above.

If you get back a blank result, it is because you did not type a description when entering the project in the client.

If you get back more than one row it is because there may be several different records (project records, contact records, appointments) with the same record ID. The `type_id` field on the text record tells us who the text record belongs to.

> [!NOTE]
> The text record has a type and an `owner_id`. The type values are described in the [text table reference documentation][1].

Some of the values used are:

* 6 = project description
* 11 = project post-it text

This mechanism (of having a type-id and an `owner_id`) is used several places in the database. The advantage is that it is very flexible, since new tables can have text added to them just by defining a new type-id to use in the text table.

The downside is that the joins become more complex, since you need to specify both the type and the `owner_id` when joining with the `text` table.

Another down-side is that this mechanism is impossible to define cleanly with referential integrity constraints.

You can add a project post-it text if you click on the **Note** button in the middle of the toolbar at the bottom of the SuperOffice client screen. This will attach a yellow note to the card.

The text you type into the note also goes into the text table, with the same `owner_id`, but with a different type ID.

<!-- Referenced links -->
[1]: ../tables/text.md
