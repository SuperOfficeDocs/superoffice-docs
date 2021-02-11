---
title: Truncate table
description: How to truncate a table.
author: AnthonyYates             # Your GitHub alias.
so.date: 29.02.2021
keywords: data-access, mass-operations, bulk-update
version: 9.2 R04
---

# Mass Operations - Truncate

Used when there is a need to remove all records in a table.

### Working with Truncate

All rows in the table are deleted using TRUNCATE TABLE or a corresponding SQL commands. This is typically an irrecoverable deletion of all rows in the table. It is extremely fast and almost independent of table size.

#### REST API Truncate

```http
DELETE /api/v1/Table/y_foobar 
```

This will truncate the whole table, but won"t delete the table itself. (That would be a schema change, and is handled elsewhere).

Truncate is only allowed on extra tables. Attempts to truncate built-in tables like Contact or Person will fail with not-allowed error.