---
title: Mass Operations
description: How to change large numbers of records in bulk.
author: AnthonyYates
so.date: 02.29.2021
keywords: data-access, bulk-update
version: 9.2 R04
so.topic: concept
---

# Mass Operations

SuperOffice APIs support the import and update of large datasets via the Mass Operations API. These APIs leverage database server bulk copy features optimized for speed.

Mass Operation functions are intentionally generic and operate towards one table at a time. They bypass all sentry security checks and therefore require an authenticated system user account to use.

> [!NOTE]
> Must be a system user. Read about [system user accounts][1].
> Supported database servers are Microsoft SQL Server and Oracle Database Servers.

## Functions

| Function  | Purpose            | Comment                         |
|-----------|--------------------|---------------------------------|
| [Delete](delete.md)    | Delete multiple rows by primary key | More efficient than deleting rows one by one but less efficient than truncate. |
| [Insert](insert.md)    | Add new rows.      | No primary key needs to be specified, all rows are simply added. Any collision with unique indexes causes an exception. |
| [Truncate](truncate.md)  | Delete all rows in a table. | Unconditional, non-recoverable truncation of the table. Very fast, near-instant. Resets primary key value to 1. |
| [Upsert](upsert.md)    | Add or update rows by key | Key column(s) designate target rows. Rows that have *no* key match are treated as **insert** rows. **No support for Oracle**. |

> [!CAUTION]
> Mass operations do not work on these [protected-tables][4].

## Working with mass operations

### Field values

The number of columns on both *target columns* and *row columns* must be the same. That means when five target columns are defined, each data row is expected to contain exactly five columns as well. The following example demonstrates a `contact` table insert and specified the five fields: contact ID, name, country, business, and category. Notice the data input contains rows with matching five columns. An `SoMassOperationException` is thrown when the number of specified columns does not match the number of data row columns.

```csharp
// specified column 
string[] columns = { "contact_id", "name", "country_id", "business_idx", "category_idx" };

// data rows and column data

string[][] data = 
{
    new [] { "0", "Red A",    "220", "6", "3" },
    new [] { "0", "Orange A", "98",  "1", "2" },
    new [] { "0", "Yellow A", "27",  "4", "1" },
    new [] { "0", "Green A",  "61",  "0", "0" },
    new [] { "0", "Blue A",   "104", "9", "1" },
    new [] { "0", "Indigo A", "109", "8", "4" },
    new [] { "0", "Violet A", "186", "5", "4" }
};

```

**Primary keys** must always be the first column in the list. When targeting extra tables, the primary key fields must always be specified. When the `Insert` method is used, specifying the primary key column for built-in Sales and Service tables is optional, but recommended. A primary key column value must be a positive number. For both an `Insert` and `Upsert`, 0 means "please assign".

Most tables have **non-nullable fields** that must be included as specified columns with default values. Use the [Database Reference documentation][2] to determine which fields are required. For a complete list, see the [Tables][3] section.

The following non-nullable columns are handled by NetServer:

* registered and updated fields
* DBI related fields in extra tables
* user-defined fields; if only those are missing from the incoming then we'll supply them

**Nullable fields**, if not specified, are set to their intrinsic data type default values.

Make sure **string field values** do not exceed the database string length, or other data type limitations are enforced, otherwise a `SoMassOperationException` is thrown.

### Data formats

To avoid any serialization problems, or database data type conflicts, it's recommended to encode all non-string values. NetServer uses the `CultureDataFormatter` class to format all non-string values and uses monikers to encode the various data types. When used, the data row columns appear as the values encapsulated in square brackets seen below. The format is "[" moniker:value "]", without spaces. For more information about encoding and decoding values, see the [CultureDataFormatter][5] documentation.

**Data rows and column values:**

| *Columns* :| x_field_id | x_name       | x_description | x_height   | x_width    |
|----------|-----------|-------------|-------------|-----------|-----------|
| _**Row**_ | "[I:0]"    | "cat"        | "in a hat"   | "[I:123]"  | "[F:321.4] "|
| _**Row**_ | "[I:0]"    | "Foozle"     | "Not woozels" | "[I:69]"   | "[F:123.5] "|
| _**Row**_ | "[I:0]"    | "Screwdriver" | "Philips head" | "[I:54]"   | "[F:345.3] "|

You don't *have* to encode every value. Internally, NetServer does accept un-encoded values, however, DateTime-related data types are often the source of problems and it is therefore recommended to use `CultureDataFormatter.Encode(object)` to format all non-string values. This, of course, assumes you are using one of our NetServer libraries.

## Webhooks and Travel Transaction Log

SuperOffice does not support [webhooks][6] or travel transaction logging for extra tables, however, all other table changes do send out appropriate webhook notifications to subscribers, row by row. Each change is also added to [travel transaction log][3] table.

<!-- Referenced links -->
[1]: ../../../authentication/online/auth-application/index.md
[2]: ../../../../../database/docs/index.yml
[3]: ../../../../../database/docs/tables/index.md
[4]: protected-tables.md
[5]: ../../globalization-and-localization/culture/culturedataformatter.md
[6]: ../../webhooks/index.md
