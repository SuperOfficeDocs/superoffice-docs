---
# This basic template provides core metadata fields for Markdown articles on docs.superoffice.com.

# Mandatory fields.
title: project_type_and_url       # (Required) Very important for SEO. Intent in a unique string of 43-59 chars including spaces.
description: Project type and URLs # (Required) Important for SEO. Recommended character length is 115-145 characters including spaces.
author: {github-id}             # Your GitHub alias.
keywords: database
so.topic:                       # article, howto, reference, concept, guide

# Optional fields. Don't forget to remove # if you need a field.
# so.envir:                     # cloud or onsite
# so.client:                    # online, web, win, pocket, or mobile
---

# Project type and URLs

Let’s find these records in the database.

```SQL
SELECT * FROM project WHERE name = 'client sdk work'
```

We need to make a note of the values in the field: `type_idx` and `project_id`.

## Project Type record

To find the project type:

```SQL
SELECT * FROM projtype WHERE projtype_id = 1234
```

Replace the 1234 with the `type_idx` you made a note of earlier.

Here you will note that we get one record with a text and a tooltip description. The tooltip is displayed when you hover the mouse over the text, and when you are editing the record.

Later, we will look at components which do all this hard work of joining different tables for us.

## URL records

If you want to put together a list of the URLs that belong to this project, the SQL is this:

```SQL
SELECT * FROM url WHERE project_id = 1234 ORDER BY rank
```

There may be several URLs all referencing the same `project_id`. This is OK. The URLs will be presented in rank order. The first rank will always be 1.
