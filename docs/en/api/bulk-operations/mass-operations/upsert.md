---
title: Upsert records
description: How to insert/update large numbers of records in bulk.
keywords: data-access, mass-operations, bulk-update
author: AnthonyYates
date: 02.29.2021
version: 9.2 R04
content_type: howto
category: api
topic: mass operations
redirect_from: /en/api/netserver/bulk-operations/mass-operations/upsert
---

<!-- markdownlint-disable-file MD051 -->
# Working with Upsert

Notably, the most complex mass operation method, `Upsert`, performs any combination of inserts, updates, and, in some cases, deletes. It requires the same parameters as the [Insert][1] method, but adds a string array of *keys*, and an `UpsertNomatchAction` enum.

```csharp
Upsert(tableName, columns, keys, deleteUnmatched, data);
```

| Parameter   | Description                                                  |
|-------------|--------------------------------------------------------------|
| TableName   | The name of the table to update.                             |
| Columns     | Array of *ordered* column names, same number as incoming data columns. |
| Keys        | Array of column names used to match one or more *ordered* column names.|
| UpsertNomatchAction | Action to take on target table rows that do not match any incoming keys |
| Data        | Two-dimension array of row and ordered column data.          |

## Key fields

A key is a column name, and the *keys* parameter is an array of keys that contain either:

* The primary key column name.
* One or more table column names that match none or one unique database record.

When the target table is a **built-in table**, and the `keys` parameter contains just the primary key column name, the operation iterates all records in the dataset and determines whether it should perform an UPDATE and an INSERT for that row. Records in the dataset with a matching primary key are updated while records with a primary key value of `0` are inserted.

When the target table in an **extra table** and the `keys` parameter contains just the primary key column name, the only permissible action is an **Update**. The reason is that the `id` field must also be included in the **columns** array to match a table record. If an extra-table `id` field in the incoming data matrix is `null` or `"0"`, an exception is thrown with the message **extra tables use database-assigned primary keys, therefore the primary key column cannot be specified for Insert**.

When the key parameter contains one or more column names, the `Upsert` operation finds the first database row where there is a matching dataset key record data and performs an Update. Matches must be unique.

## Matching behavior

The `UpsertNomatchAction` enum option is used to determine what action to take on records that do not match the key criteria.

| Enum value  | Description                                     |
|-------------|-------------------------------------------------|
| NoChange    | No action, leave target table row unchanged     |
| ZeroColumns | Zero/default-value the targeted `columns` in all non-matching rows |
| DeleteRow   | Delete the entire row, for all non-matching-row |

When using the Agent API, the only option available is the boolean parameter `deleteUnmatched`. When true, any rows that do not match a record are deleted. In this case, when the method is finished, the table mirrors the incoming data. If that is the intent, it might be faster to consider using a `Truncate` and then an `Insert` instead.

When targeting **user-defined tables** (udxxxsmall or udxxxlarge), the `UpserNomatchAction` must be set to **NoChange**. When using the Agent API, `deleteUnmatched` must be set to false.

## User-defined fields

> [!CAUTION]
> When updating **user-defined fields**, `DeleteUnmatched` must be false.

When targeting user-defined fields tables, such as `udcontsmall` or `udcontlarge`, the column names can be program ID (`progid`) instead of the table column name, such as `long05`.

Upsert is always oriented towards one table. Therefore when the target table is a user-defined table, only specify ProgIDs for one of the user-defined tables at a time. Target either `udfXxxSmall` or `udfXxxLarge`, ensuring not to mix columns from both tables in one Upsert.

When updating User-defined field, specify the entity primary key column as the key, and primary key value in the data array. Any new UDEF rows are automatically linked to their owner entity.

> [!WARNING]
> A failed Upsert can leave the database in a *partially* updated state. There is extensive validation, but there are no guarantees. Make sure to inspect the `MassResults` return type and review what changes have occurred.

## Example table upsert example

**Rental Gear table:**

| id | code | qty | description   |
|:--:|------|:---:|---------------|
| 1 | SB    | 10  | Street Bike   |
| 2 | ORB   | 10  | Mountain Bike |
| 3 | XO    | 1   | Extra Bike    |
| 4 | UB    | 3   | Uni Bicycle   |

### [Agent API](#tab/upsert-extra-table-1)

```csharp
using SuperOffice.WebApi;
using SuperOffice.WebApi.Data;
using SuperOffice.WebApi.Agents;

// set up the DatabaseTable agent

WebApiOptions options = //Get WebApiOptions with SystemUser Authorization
var dta = new DatabaseTableAgent(options);

string tableName = "y_rental_gear";

// table columns

string[] columns = { "x_code", "x_quantity", "x_description" };

// key column 

string[] keys = { "x_code" };

// table row data 

string[][] data =
{
    new [] { "XO", "7", "Extra-Ordinary Bike" },
    new [] { "UB", "10", "Uni-cycle" }
};

MassOperationResult results = await dta.UpsertAsync(tableName, columns, keys, false, data);
```

### [Core API](#tab/upsert-extra-table-2)

```csharp
using SuperOffice.Data.Dialect;

var mo = MassOperations.GetCurrent();

string tableName = "y_rental_gear";

// table columns

string[] columns = { "x_code", "x_quantity", "x_description" };

// key column 

string[] keys = { "x_code" };

// table row data 

string[][] data =
{
    new [] { "XO", "7", "Extra-Ordinary Bike" },
    new [] { "UB", "10", "Uni-cycle" }
};

MassResult massResult = mo.Upsert(tableName, columns, keys, data, UpsertNomatchAction.NoChange);
```

***

This will update 3 rows in the `y_rental_gear` table. It will match the records by code with ID 3 and 4, and update their quantity and description fields.

| id | code | qty | description   |
|:--:|------|:---:|---------------|
| 1  | SB   | 10  | Street Bike   |
| 2  | ORB  | 10  | Mountain Bike |
| 3  | XO   | 7   | Extra-Ordinary Bike |
| 4  | UB   | 10  | Uni-cycle     |

## Contact table upsert example

See [contact table][2] in database reference guide.

### [Agent API](#tab/upsert-contact-1)

```csharp
using SuperOffice.WebApi;
using SuperOffice.WebApi.Data;
using SuperOffice.WebApi.Agents;

// set up the DatabaseTable agent

WebApiOptions options = //Get WebApiOptions with SystemUser Authorization
var dta = new DatabaseTableAgent(options);

string tableName = "contact";

// table columns (non-nullable columns)

string[] columns = { "name", "country_id", "business_idx", "category_idx" };

// key column 

string[] keys = { "name" };

// table row data 

string[][] data =
{
    new [] { "Red",    "[I:5]", "[I:3]", "[I:1]" },
    new [] { "Orange", "[I:4]", "[I:4]", "[I:1]" },
    new [] { "Yellow", "[I:3]", "[I:5]", "[I:2]" },
    new [] { "Green",  "[I:2]", "[I:3]", "[I:2]" },
    new [] { "Blue",   "[I:1]", "[I:4]", "[I:3]" },
    new [] { "Indigo", "[I:2]", "[I:5]", "[I:3]" },
    new [] { "Violet", "[I:3]", "[I:3]", "[I:4]" },
};
MassOperationResult results = await dta.UpsertAsync(tableName, columns, keys, false, data);
```

### [Core API](#tab/upsert-contact-2)

```csharp
using SuperOffice.Data.Dialect;

var mo = MassOperations.GetCurrent();

string tableName = "contact";

// table columns (non-nullable columns)

string[] columns = { "name", "country_id", "business_idx", "category_idx" };

// key column 

string[] keys = { "name" };

// table row data 

string[][] data =
{
    new [] { "Red",    "[I:5]", "[I:3]", "[I:1]" },
    new [] { "Orange", "[I:4]", "[I:4]", "[I:1]" },
    new [] { "Yellow", "[I:3]", "[I:5]", "[I:2]" },
    new [] { "Green",  "[I:2]", "[I:3]", "[I:2]" },
    new [] { "Blue",   "[I:1]", "[I:4]", "[I:3]" },
    new [] { "Indigo", "[I:2]", "[I:5]", "[I:3]" },
    new [] { "Violet", "[I:3]", "[I:3]", "[I:4]" },
};
MassResult massResult = mo.Upsert(tableName, columns, keys, data, UpsertNomatchAction.NoChange);
```

***

## User-defined field upsert example

See [uddocsmsall table][3] in the database reference guide.

### [Agent API](#tab/upsert-udef-1)

[!code-csharp[CS](../includes/mass-operation-upsert-uddocsmall-table.cs)]

### [Core API](#tab/upsert-udef-2)

[!code-csharp[CS](../includes/mass-operation-upsert-uddocsmall-table-core.cs)]

***

Upsert can be asked to return a **row-by-row** status: for each row you get back your key columns, and an enum specifying what happened (insert/update/delete/zero/nochange).

<!-- reference links -->

[1]: insert.md
[2]: ../../../database/tables/contact.md
[3]: ../../../database/tables/uddocsmall.md
