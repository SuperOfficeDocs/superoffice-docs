---
title: Truncate table
description: How to truncate a table.
keywords: data-access, mass-operations, bulk-update
author: AnthonyYates
date: 02.29.2021
version: 9.2 R04
content_type: howto
category: api
topic: mass operations
redirect_from: /en/api/netserver/bulk-operations/mass-operations/truncate
---

<!-- markdownlint-disable-file MD051 -->
# Working with Truncate

This method is used to remove all records in a table. All records afterward are irrecoverable. It is extremely fast, dependent on table size.

> [!WARNING]
> This will truncate the whole table, but won't delete the table itself.

## Truncate Examples

### [Agent RESTful API](#tab/truncate-1)

```csharp
using SuperOffice.WebApi;
using SuperOffice.WebApi.Data;
using SuperOffice.WebApi.Agents;


// set up the DatabaseTable agent

WebApiOptions options = //Get WebApiOptions with SystemUser Authorization
DatabaseTableAgent dta = new DatabaseTableAgent(options);

// table name

string tableName = "y_rental";

MassOperationResult massResult = await dta.TruncateAsync(tableName);

if(massResult.Success)
{
    Console.WriteLine($"Removed {massResult.Deletes} records from {tableName}.");
}
```

### [Core API](#tab/truncate-2)

```csharp
using SuperOffice.Data.Dialect;

var mo = MassOperations.GetCurrent();

// table name

string tableName = "y_rental";

MassResult massResult = mo.Truncate(tableName);

if(massResult.Success)
{
    Console.WriteLine($"Removed {massResult.Deletes} records from {tableName}.");
}
```

***
