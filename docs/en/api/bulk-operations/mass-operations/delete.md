---
title: Delete records
description: How to delete large numbers of records in bulk.
keywords: data-access, mass-operations, bulk-update
author: AnthonyYates
date: 02.29.2021
version: 9.2 R04
content_type: howto
category: api
topic: mass operations
redirect_from: /en/api/netserver/bulk-operations/mass-operations/delete
---

<!-- markdownlint-disable-file MD051 -->
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

```csharp
using SuperOffice.WebApi;
using SuperOffice.WebApi.Data;
using SuperOffice.WebApi.Agents;

// set up the DatabaseTable agent

WebApiOptions options = //Get WebApiOptions with SystemUser Authorization
var dbTableAgent = new SuperOffice.WebApi.Agents.DatabaseTableAgent(options);

// set the table name and primary key parameters

string tableName = "y_myExtraTableName";
int[] primaryKeys = { 1,2,3,4,5,6,7,8,9 };

// perform the delete operation

var massOperationResult = await dbTableAgent.DeleteAsync(tableName, primaryKeys);

// check the result status and print out the number of changes.

if(massOperationResult.Success)
{
    Console.WriteLine($"Deleted {massOperationResult.Deletes} records from {tableName}.");
}
```

## [NetServer Core](#tab/delete-2)

```csharp
using SuperOffice.Data.Dialect;

// set the table name and primary key parameters

string tableName = "y_myExtraTableName";
int[] primaryKeys = {1,2,3,4,5,6,7,8,9};

var mo = MassOperations.GetCurrent();

// perform the delete operation

MassResult massResult = mo.Delete(tableName, primaryKeys);

// check the result status and print out the number of changes.

if(massOperationResult.Success)
{
    Console.WriteLine($"Deleted {massOperationResult.Deletes} records from {tableName}.");
}
```

***

<!-- Referenced links -->

[1]: protected-tables.md
