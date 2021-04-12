---
title: Insert records
description: How to insert large numbers of records in bulk.
author: AnthonyYates             # Your GitHub alias.
so.date: 29.02.2021
keywords: data-access, mass-operations, bulk-update
version: 9.2 R04
---

# Working with Insert

Used when there is a need to insert multiple records in a table, Insert requires a target table name, an array of target column names and a matching dataset. The dataset must be a two-dimensional array of string values, where the first dimension represents the data rows and the second dimension represents each data cell in the row.

## Data rows and column values

**Built-in table:**

| *Columns*: | contact_id  | name       | country_id | business_idx | category_idx |
|------------|-------------|------------|------------|--------------|--------------|
| _**Row**_  | "0"         | "Company1" | "220"      | "[I:6]"      | "[I:3]"      |
| _**Row**_  | "0"         | "Company2" | "98"       | "[I:1]"      | "[I:2]"      |
| _**Row**_  | "0"         | "Company3" | "27"       | "[I:4]"      | "[I:1]"      |

**Extra table:**

| *Columns*: | x_name        | x_description  | x_height   | x_width     |
|------------|---------------|----------------|------------|-------------|
| _**Row**_  | "cat"         | "in a hat"     | "[I:123]"  | "[F:321.4]" |
| _**Row**_  | "Foozle"      | "Not woozels"  | "[I:69]"   | "[F:123.5]" |
| _**Row**_  | "Screwdriver" | "Philips head" | "[I:54]"   | "[F:345.3]" |

`Built-in tables` do not have to specify a primary key column. When not specified, all rows are automatically assigned primary key value from the sequence table. When present and equal to "0" or [I:0] they are assigned from the sequence table. When primary key column values are greater than 0, they are used as-is, however, the operation aborts if there is a collision.

> [!CAUTION]
> Extra tables **must not** specify a primary key column.

## Insert Example

### [Agent RESTful API](#tab/insert-1)

#### Insert example

[!code-csharp[CS](../includes/mass-operation-insert.cs)]

### [Core API](#tab/insert-2)

#### Insert example

[!code-csharp[CS](../includes/mass-operation-insert-core.cs)]
***

The example inserts 2 rows into the `y_rental` table. Other unspecified columns in the table will be set to default values. As is with all extra tables, the primary key `y_rental.id`  will be auto-incremented by the database.
