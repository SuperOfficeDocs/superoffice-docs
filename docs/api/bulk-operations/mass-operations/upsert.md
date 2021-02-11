---
title: Upsert records
description: How to insert/update large numbers of records in bulk.
author: AnthonyYates             # Your GitHub alias.
so.date: 29.02.2021
keywords: data-access, mass-operations, bulk-update
version: 9.2 R04
---

# Mass Operations - Upsert

Used when there is a need to both insert and update multiple records in a table.

## Working with Upsert

`Upsert` is notably the most complex method. It can perform any combination of inserts, updates and deletes. It requires the same parameters as the [Insert][1] method, as well as an array of key columns and a boolean used to determine whether unmatched records are deleted.

Key column values are generally either:

1. The primary key column name.
2. One or more table column names
   1. Primary key is not required, but the combination must match one unique database record.
   2. Matching multiple non-unique records is not supported.

When the key equals the primary key column name, the operation iterates over all records in the dataset and determines whether it should perform an UPDATE and an INSERT in the database for that row. Records in the dataset with a matching primary key are updated while records with a primary key value of `0` are inserted.

When the key array contains one or more columns, the Upsert operation finds the first database row that matches the dataset key record data and performs an Update. Non-unique matches are not supported.

The deleteUnmatched parameter is used to determined whether Upsert should keep or remove records in the database table. When true, any rows that have **not** been matched or inserted are deleted; the table then mirrors the incoming data. If that is the intent, it might be faster to perform a `Truncate` and then an `Insert`.

When updating user-defined fields, the DeleteUnmatched must be not be set.

A failed Upsert can leave the database in a *partially* updated state. There is extensive validation to catch things, such as badly formatted fields or too-long strings, but there are ultimately no guarantees. Make sure to inspect the `MassResults` return type to action results and/or errors.

### Example

This method has three main parameters: An array of field names to be updated; an array of field names that together constitute a unique key for identifying rows; and a matrix of values with both the key and data fields specified for each row. In addition, one can specify the action to be taken for unmatched rows, and how much return information is desired (detailed row-by-row status takes time and resources).

|Parameter   | Description                                                  |
|------------|--------------------------------------------------------------|
|TableName   | The name of the table to update.                             |
|Columns     | List of ordered columns, same as incoming data.              |
|Keys        | List of key columns that must match one or more column values.|
|Delete Unmatched | Determines set operation behavior. If true, unmatched rows are deleted. If false, unmatched rows are inserted. |
|Data        | Two-dimension array of row and ordered column data.          |

The key field may be the database primary key, or a combination of one or more field(s) that uniquely identifies a row. 
When the combination of key values match a row, an update operation is performed; otherwise the matching row is updated. If there is a multiple match, the operation is aborted. [or should we use this as a way of allow multiple rows to be efficiently updated to the same values?]

# [Agent API](#tab/upsert-2)
#### Upsert method example
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
