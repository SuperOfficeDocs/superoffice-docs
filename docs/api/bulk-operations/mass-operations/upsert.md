---
title: Upsert records
description: How to insert/update large numbers of records in bulk.
author: AnthonyYates             # Your GitHub alias.
so.date: 29.02.2021
keywords: data-access, mass-operations, bulk-update
version: 9.2 R04
---

# Working with Upsert

Notably the most complex mass operation method, Upsert performs any combination of inserts, updates and, in some cases, deletes. It requires the same parameters as the [Insert][1] method, but adds a string array of *keys*, and an UpsertNomatchAction enum.

```csharp
Upsert(tableName, columns, keys, deleteUnmatched, data);
```

|Parameter   | Description                                                  |
|------------|--------------------------------------------------------------|
|TableName   | The name of the table to update.                             |
|Columns     | Array of *ordered* column names, same number as incoming data columns.              |
|Keys        | Array of column names used to match one or more *ordered* column names.|
|UpsertNomatchAction | Action to take on target table rows that do not match any incoming keys |
|Data        | Two-dimension array of row and ordered column data.          |

## Key fields

A key is a column name, and the *keys* parameter is an array of keys that contain either:

1. The primary key column name.
2. One or more table column names that match none or one unique database record.

When the target table is a **built-in table**, and the **keys** parameter contains just the primary key column name, the operation iterates over all records in the dataset and determines whether it should perform an UPDATE and an INSERT for that row. Records in the dataset with a matching primary key are updated while records with a primary key value of `0` are inserted.

When the target table in an **extra table**, and the **keys** parameter contains just the primary key column name, the only permissible action is an **Update**. The reason is that the **id** field must also be included in the **columns** array to match a table record. If an extra-table **id** field in the incoming data matrix is `null` or `"0"`, an exception is thrown with the message **extra tables use database-assigned primary keys, therefore the primary key column cannot be specified for Insert**.

When the key parameter contains one or more column names, the Upsert operation finds the first database row where there is a matching dataset key record data and performs an Update. Matches must be unique.

## Matching behavior

The `UpsertNomatchAction` enum option is used to determine what action to take on records that do not match the key criteria.

| Enum value | Description                                    |
|------------|------------------------------------------------|
|NoChange    |No action, leave target table row unchanged     |
|ZeroColumns |Zero/default-value the targeted `columns` in all non-matching rows |
|DeleteRow   |Delete the entire row, for all non-matching-row |

When using the Agent API, the only option available is the boolean parameter *deleteUnmatched*. When true, any rows that do not match a record are deleted. In this case, when the method is finished, the table mirrors the incoming data. If that is the intent, it might be faster to consider using a `Truncate` and then an `Insert` instead.

When targeting **user-defined tables**, i.e. udxxxsmall or udxxxlarge, the `UpserNomatchAction` must be set to **NoChange**. When using the Agent Api, deleteUnmatched must be set to false.

## User-defined fields

When targeting user-defined fields tables, such as `udcontsmall` or `udcontlarge`, the column names can be program ID (progid) instead of table column name, i.e. long05.

Upsert is always oriented towards one table. Therefore when the target table is a user-defined table, only specify ProgID's for one of the user-defined tables at a time. Target either udfXxxSmall or udfXxxLarge, ensuring not to mix columns from both tables in one Upsert.

User-defined field rows are not automatically linked to their owner entity, that needs to be done to entities with the appropriate udef_large_id / udef_small_id fields.

> [!CAUTION]
> When updating **user-defined fields**, DeleteUnmatched must be false.

> [!WARNING]
> A failed Upsert can leave the database in a *partially* updated state. There is extensive validation, but there are no guarantees. Make sure to inspect the `MassResults` return type and review what changes have occurred.

## Example table upsert example

**Rental Gear table**

|id|code|qty|description  |
|--|----|---|-------------|
|1 |SB  |10 |Street Bike  |
|2 |ORB |10 |Mountain Bike|
|3 |XO  |1  |Extra Bike   |
|4 |UB  |3  |Uni Bicycle  |

# [Agent API](#tab/upsert-extra-table-1)

[!code-csharp[CS](../includes/mass-operation-upsert-extra-table.cs)]

# [Core API](#tab/upsert-extra-table-2)

[!code-csharp[CS](../includes/mass-operation-upsert-extra-table-core.cs)]

***

This will update 3 row in the y_rental_gear table. It will match the records by code with ID 3 and 4, and update their quantity and description fields.

|id|code|qty|description  |
|--|----|---|-------------|
|1 |SB  |10 |Street Bike  |
|2 |ORB |10 |Mountain Bike|
|3 |XO  |7  |Extra-Ordinary Bike|
|4 |UB  |10 |Uni-cycle    |

## Contact table upsert example

See [contact table][2] in database reference guide.

# [Agent API](#tab/upsert-contact-1)

[!code-csharp[CS](../includes/mass-operation-upsert-contact-table.cs)]

# [Core API](#tab/upsert-contact-2)

[!code-csharp[CS](../includes/mass-operation-upsert-contact-table-core.cs)]

***

## User-defined field upsert example

See [uddocsmsall table][3] in database reference guide.

# [Agent API](#tab/upsert-udef-1)

[!code-csharp[CS](../includes/mass-operation-upsert-uddocsmall-table.cs)]

# [Core API](#tab/upsert-udef-2)

[!code-csharp[CS](../includes/mass-operation-upsert-uddocsmall-table-core.cs)]

***

Upsert can be asked to return a **row-by-row** status: for each row you get back your key columns, and an enum specifying what happened (insert/update/delete/zero/nochange).

<!-- reference links -->

[1]: insert.md
[2]: https://github.com/SuperOfficeDocs/database/blob/main/docs/tables/contact.md
[3]: https://github.com/SuperOfficeDocs/database/blob/main/docs/tables/uddocsmall.md
