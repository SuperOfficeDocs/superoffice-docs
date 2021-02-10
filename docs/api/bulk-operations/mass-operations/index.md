---
title: Mass Operations
description: How to change large numbers of records in bulk.
author: AnthonyYates             # Your GitHub alias.
so.date: 29.02.2021
keywords: data-access, bulk-update
version: 9.2 R04
---

# Mass Operations

SuperOffice APIs support the import and update of large datasets via the Mass Operations API. These APIs leverage database server bulk copy features optimized for speed.

Mass Operation functions are intentionally generic, and operate towards one table at a time. They bypass all sentry security checks and therefore when called require an authenticated system user account.

> [!NOTE]
> Must be a system user. Read about [system user accounts][1].
> Supported database servers are Microsoft SQL Server and Oracle Database Servers.

## Functions

| Function  | Purpose            | Comment                         |
|-----------|--------------------|---------------------------------|
| [Delete](delete.md)    | Delete multiple rows by primary key | More efficient that deleting rows one by one but less efficient than truncate. |
| [Insert](insert.md)    | Add new rows.      | No primary key need be specified, all rows are simply added. Any collision with unique indexes causes an exception. |
| [Truncate](truncate.md)  | Delete all rows in a table. | Unconditional, non-recoverable truncation of table. Very fast, near-instant. Resets primary key value to 1. |
| [Upsert](upsert.md)    | Add or update rows by key | Key column(s) designate target rows. Rows that have *no* key match are treated as **insert** rows. **Not supported for Oracle**. |

> [!CAUTION]
> Mass operations do not work on these [protected-tables](protected-tables.md).

## Working with Mass Operations

### Field Values

Data input row columns must match the same number of specified columns. That means when five columns are defined, each data rows is expected to also contain five columns. The following example demonstrates a contact table insert, and specified the five fields: contact ID, name, country, business and category. Notice the data input contains rows with matching five columns. An `SoMassOperationException` is thrown when the number of specified columns do not match the number of data row columns.

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

Primary keys must always be the first column in the list. When targeting extra tables, the primary key fields must always be specified. When the `Insert` method is used, specifying the primary key column for built-in Sales and Service tables is optional, but recommended. A primary key column value must be a positive number. For both an `Insert` and `Upsert`, 0 means "please assign".

Most tables have non-nullable fields that must be included as specified columns with default values. Use the [Database Reference documentation][2] to determine which fields are required. For a complete list, see the [Tables](https://github.com/SuperOfficeDocs/database/blob/main/docs/tables/index.md) section.

The following non-nullable columns are handled by NetServer:

* registered and updated fields
* DBI related fields in extra tables
* user-defined fields; if only those are missing from the incoming then we'll supply them

Nullable fields, if not specified, are set to their intrinsic data type default values.

Make sure string field values do not exceed the database string length, or other data type limitations are enforced, otherwise a `SoMassOperationException` is thrown.

### Data Formats

To avoid any serialization problems, or database data type conflicts, it's recommended to encode all non-string values. NetServer uses the following monikers to encode the various data types:

**CultureDataFormatter monikers**

|Data type |Marker|
|----------|------|
|Date      | D    |
|DateTime  | DT   |
|Time      | T    |
|TimeSpan  | TS   |
|Double    | F    |
|Int       | I    |
|Money     | M    |
|Binary    | B    |
|IntArr    | A    |

When used, the data row columns appear as follows:

**Data rows and column values**

|       |             |             |         |           |
|-------|-------------|-------------|---------|-----------|
|"[I:0]"|"cat"        |"in a hat"   |"[I:123]"|"[F:321.4]"|
|"[I:0]"|"Foozle"     |"Not woozels"|"[I:69]" |"[F:123.5]"|
|"[I:0]"|"Screwdriver"|"Phiips head"|"[I:54]" |"[F:345.3]"|

Use `SuperOffice.CRM.Globalization.CultureDataFormatter.Encode(object)` to format non-string values. This outputs an encoded string representation for each input. As a convenience, CultureDataFormatter accepts un-encoded values also, but beware of date-time formatting is often a source of problems.


### Handling Errors

Errors are returned as a Bad Request error with an explanatory exception text that generally tries to pinpoint the problem, row and column.

Each input column must exist in the target table.

Input columns and the number of row fields much match, otherwise a `SoMassOperationException` is thrown.


<!-- Referenced links -->
[1]: https://github.com/SuperOfficeDocs/superoffice-docs/docs/authentication/system-user/index.md
[2]: https://github.com/SuperOfficeDocs/database/blob/main/docs/index.md