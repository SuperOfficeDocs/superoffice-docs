---
title: Mass Operations - Delete
description: How to delete large numbers of records in bulk.
author: AnthonyYates             # Your GitHub alias.
so.date: 29.02.2021
keywords: data-access, mass-operations, bulk-update
version: 9.2 R04
---

# Mass Operations - Delete

## Working with Delete

Delete requires an array of primary key values, which has no size limit. To avoid any unnecessary database server side-affects, i.e. long locks, NetServer processes the operation in batches of 1000.

Rules that govern soft-delete entities are still respected. This means the delete operation doesn't physically remove the database record, but instead updates the SoftDeletedDate column.

### Delete

The specified rows are deleted in an efficient way, subject to Sentry permissions. The time taken is proportional to the number of rows deleted.

```csharp
BulkDelete(string tableName, int[] primaryKeys) 
```

#### REST API Delete

```http
DELETE /api/v1/Table/y_foobar/1,2,3,5,8,13,21 
```

This will delete the specified rows from the table. A URL is typically allowed to be somewhere between 1 and 4kB – so the REST API could accept 250 to 1000 ids per call.

Bulk Delete is allowed on extra tables and on the built-in tables.