---
title: Insert records
description: How to insert large numbers of records in bulk.
keywords: data-access, mass-operations, bulk-update
author: AnthonyYates
date: 02.29.2021
version: 9.2 R04
content_type: howto
category: api
topic: mass operations
redirect_from: /en/api/netserver/bulk-operations/mass-operations/insert
---

<!-- markdownlint-disable-file MD051 -->
# Working with Insert

Used when there is a need to insert multiple records in a table, Insert requires a target table name, an array of target column names and a matching dataset. The dataset must be a two-dimensional array of string values, where the first dimension represents the data rows and the second dimension represents each data cell in the row.

## Data rows and column values

**Built-in table:**

| *Columns*: | contact_id  | name       | country_id | business_idx | category_idx |
|------------|-------------|------------|------------|--------------|--------------|
| **Row**  | "0"         | "Company1" | "220"      | "[I:6]"      | "[I:3]"      |
| **Row**  | "0"         | "Company2" | "98"       | "[I:1]"      | "[I:2]"      |
| **Row**  | "0"         | "Company3" | "27"       | "[I:4]"      | "[I:1]"      |

**Extra table:**

| *Columns*: | x_name        | x_description  | x_height   | x_width     |
|------------|---------------|----------------|------------|-------------|
| **Row**  | "cat"         | "in a hat"     | "[I:123]"  | "[F:321.4]" |
| **Row**  | "Foozle"      | "Not woozels"  | "[I:69]"   | "[F:123.5]" |
| **Row**  | "Screwdriver" | "Philips head" | "[I:54]"   | "[F:345.3]" |

`Built-in tables` do not have to specify a primary key column. When not specified, all rows are automatically assigned primary key value from the sequence table. When present and equal to "0" or [I:0] they are assigned from the sequence table. When primary key column values are greater than 0, they are used as-is, however, the operation aborts if there is a collision.

> [!CAUTION]
> Extra tables **must not** specify a primary key column.

## Insert Example

### [Agent RESTful API](#tab/insert-1)

#### Insert example

```csharp
using SuperOffice.WebApi;
using SuperOffice.WebApi.Data;
using SuperOffice.WebApi.Agents;

// set up the DatabaseTable agent

WebApiOptions options = //Get WebApiOptions with SystemUser Authorization
DatabaseTableAgent dta = new DatabaseTableAgent(options);

// table name

string tableName = "y_rental";

// table columns (non-nullable columns)

var columns = new[] { "x_start", "x_end", "x_amount", "x_contact", "x_equipment" };

// table row data

var data = new string[][]
{
  new[] {yesterday, today, CultureDataFormatter.EncodeInt(2), "123", "0" },
  new[] {yesterday, today, CultureDataFormatter.EncodeInt(200), "456", "1" },
};

MassOperationResult results = await dta.InsertAsync(tableName, columns, data);
```

### [Core API](#tab/insert-2)

#### Insert example

```csharp
using SuperOffice.Data.Dialect;
using SuperOffice.CRM.Globalization;

var mo = MassOperations.GetCurrent();

// table name

string tableName = "y_rental";

// table columns (non-nullable columns)

var columns = new[] { "x_start", "x_end", "x_amount", "x_contact", "x_equipment" };

// use CultureDataFormatter to encode date and numerical values. 

var today = CultureDataFormatter.EncodeDateTime(DateTime.Today.DropFractionsOfSecond());
var yesterday = CultureDataFormatter.EncodeDateTime(DateTime.Today.AddDays(-1).DropFractionsOfSecond());

// table row data

var data = new string[][]
{
  new[] {yesterday, today, CultureDataFormatter.EncodeInt(2), "123", "0" },
  new[] {yesterday, today, CultureDataFormatter.EncodeInt(200), "456", "1" },
};

MassResult massResult = mo.Insert(tableName, columns, data);
```

***

The example inserts 2 rows into the `y_rental` table. Other unspecified columns in the table will be set to default values. As is with all extra tables, the primary key `y_rental.id`  will be auto-incremented by the database.
