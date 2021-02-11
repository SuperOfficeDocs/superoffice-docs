---
title: Insert records
description: How to insert large numbers of records in bulk.
author: AnthonyYates             # Your GitHub alias.
so.date: 29.02.2021
keywords: data-access, mass-operations, bulk-update
version: 9.2 R04
---

# Mass Operations - Insert

Used when there is a need to insert multiple records in a table.

## Working with Mass Operations

All functions require a target table name. The `Truncate` is the only method that accepts just the table name.

`Insert` requires an array of target column names and a matching dataset. The dataset must be a two-dimensional array of string values, where the first dimension represents the input rows and the second dimension represents each data cell in the row.

### Insert

Insert may or may not specify primary keys. If the primary key column is not specified in the field name array, all rows will have primary key values allocated according to standard methods. If the primary key column is specified, blank and [I:0] cells indicate that a primary key should be allocated; other integer values are used as-is. If there is a collision, the operation aborts.

# [Agent API](#tab/insert-1)
#### Insert example
[!code-csharp[CS](../includes/mass-operation-insert.cs)]

# [Core API](#tab/insert-2)
#### Insert example
[!code-csharp[CS](../includes/mass-operation-insert-core.cs)]
***

This will insert 4 rows into the y_foobar table. Other unspecified columns in the table will be set to default values. The primary key y_foobar.id will be automatically allocated by the database (since extra tables does not use sequence, but auto-increment).
