---
title: Upsert records
description: How to insert/update large numbers of records in bulk.
author: AnthonyYates             # Your GitHub alias.
so.date: 29.02.2021
keywords: data-access, mass-operations, bulk-update
version: 9.2 R04
---

# Working with Upsert

Notably the most complex mass operation method, Upsert performs any combination of inserts, updates and, in some cases, deletes. It requires the same parameters as the [Insert][1] method, but adds a string array *keys*, and a boolean *deleteUnmatched*.

```csharp
Upsert(tableName, columns, keys, deleteUnmatched, data);
```

|Parameter   | Description                                                  |
|------------|--------------------------------------------------------------|
|TableName   | The name of the table to update.                             |
|Columns     | Array of *ordered* column names, same number as incoming data columns.              |
|Keys        | Array of **key** column names used to match one or more *ordered* column names.|
|Delete Unmatched | Determines set operation behavior. If true, unmatched rows are deleted. Must be false when columns include a **user-defined field**. |
|Data        | Two-dimension array of row and ordered column data.          |

Use the deleteUnmatched to determined whether Upsert should keep or remove unmatched records in the table. When true, any rows that have **not** been matched or inserted are deleted. In this case the end result is that the table mirrors the incoming data. If that is the intent, it might be faster to perform a `Truncate` and then an `Insert`.

## Key fields

A key is a column name, and keys are either:

1. The primary key column name.
2. One or more table column names
   1. Primary key is not required, but the combination must match one unique database record.
   2. Matching multiple non-unique records is not supported.

When the key parameter contains just the primary key column name, the operation iterates over all records in the dataset and determines whether it should perform an UPDATE and an INSERT in the database for that row. Records in the dataset with a matching primary key are updated while records with a primary key value of `0` are inserted.

When the key parameter contains one or more column names, the Upsert operation finds the first database row where there is a matching dataset key record data and performs an Update. Matches must be unique.

## User-defined fields

Upsert is still oriented towards one table. Therefore when specifying user-defined fields, only specify ProgID's for either xxxSmall or xxxLarge. Do not mix columns from both tables in one Upsert.

> [!CAUTION]
> When updating **user-defined fields**, DeleteUnmatched must be false.

## Data rows and column values

**Built-in table**

|*Columns*:|contact_id |name       |country_id|business_idx|category_idx|SuperOffice:2|
|----------|-----------|-----------|----------|------------|------------|-------------|
|_**Row update**_ |"1"        |"Company1" |"220"     |"[I:6]"     |"[I:3]"     |"Phase Two"  |
|_**Row insert**_ |"0"        |"Company2" |"98"      |"[I:1]"     |"[I:2]"     |"Phase One"  |
|_**Row update**_ |"4"        |"Company3" |"27"      |"[I:4]"     |"[I:1]"     |"Phase Two"  |

**Extra table**

|*Columns*:|id  |x_name       |x_description |x_height   |x_width    |
|----------|----|-------------|--------------|-----------|-----------|
|_**Row insert**_ |"0" |"cat"        |"in a hat"    |"[I:123]"  |"[F:321.4]"|
|_**Row update**_ |"1" |"Foozle"     |"Not woozels" |"[I:69]"   |"[F:123.5]"|
|_**Row update**_ |"4" |"Screwdriver"|"Philips head"|"[I:54]"   |"[F:345.3]"|

> [!WARNING] 
> A failed Upsert can leave the database in a *partially* updated state. There is extensive validation, but there are no guarantees. Make sure to inspect the `MassResults` return type and review what changes have occurred.

## Upsert example

# [Agent API](#tab/upsert-2)

[!code-csharp[CS](../includes/mass-operation-upsert.cs)]

***

This will update 1 row and insert 3 rows into the y_foobar table. Other unspecified columns in the table will be set to default values. (Assuming row 42 already exists in the table. If it doesn't then it becomes an insert)

```javascript
PUT /api/v1/Table/y_foobar 

{ 
  fields: [ "x_col_a", "x_col_b" ], 
  key: [ "x_col_a" ], 
  data: [["x", 123], ["y", 234], ["z", 345], ["æ",null]] 
} 
```

Here the bulk upsert is using x_col_a as the key field, and so if a row already exists with value "x", then it gets updated with x_col_b = 123. If such a row does not exist, it gets inserted instead.

If row "æ" does not exist, it will be inserted, but x_col_b will be set to its default value.

Rows that are already in the target table, but do not match any of the incoming keys, can be left unchanged; deleted; or have the data columns (the non-key columns specified in the Upsert call) zeroed.

Upsert can be asked to return a **row-by-row** status: for each row you get back your key columns, and an enum specifying what happened (insert/update/delete/zero/nochange).

User-defined fields: for tables like `udcontsmall` or `udcontlarge`, the column names can be progid instead of long05.  

Inserting user defined field rows will not automatically link them to their owner – you need to update the contact row with the appropriate udef_large_id / udef_small_id fields.

#### Example:

We Upsert 4 rows on contact: 3 inserts and 1 update.  
This results in 4 webhook calls: 3 contact.created events, 1 contact.changed event.

We Upsert 4 rows on extra table y_bicycle: 3 inserts and 1 update.  

This results in 0 webhook calls: extra tables do not have webhooks (yet).

<!-- reference links -->

[1]: insert.md
