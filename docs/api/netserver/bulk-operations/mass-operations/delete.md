---
title: Delete records
description: How to delete large numbers of records in bulk.
author: AnthonyYates
so.date: 29.02.2021
keywords: data-access, mass-operations, bulk-update
version: 9.2 R04
so.topic: howto
---

# Working with Delete

Used to remove multiple records from a table, delete requires a table name and an array of primary key values. To avoid any unnecessary database server side-effects (long locks), NetServer internally processes the array of primary keys in batches of 1000.

Rules that govern **soft-delete** entities are still respected. This means delete doesn't physically remove the database record, but instead updates the SoftDeletedDate column.

The specified rows are deleted in an efficient way yet the time taken is proportional to the number of rows deleted.

```csharp
Delete(string tableName, int[] primaryKeys) 
```

> [!CAUTION]
> Mass operations do not work on these [protected-tables][1].

## Example

## [Agent RESTful API](#tab/delete-1)

[!code-csharp[CS](../includes/mass-operation-delete-agent.cs)]

## [NetServer Core](#tab/delete-2)

[!code-csharp[CS](../includes/mass-operation-delete-core.cs)]
***

<!-- Referenced links -->

[1]: protected-tables.md
