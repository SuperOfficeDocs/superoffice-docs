---
title: Mass Operations
description: How to change large numbers of records in bulk.
author: AnthonyYates             # Your GitHub alias.
so.date: 29.02.2021
keywords: data-access, bulk-update
---

# Mass Operations

Integrations use mass operations to perform insert, updates and deletes for large volumes of data. The API is intentionally generic to perform an operation towards one table at a time. Operations are extremely fast and powerful, and therefore only accessible to system user accounts. As is with system user accounts, there are no sentry security checks for any mass operation.

> [!NOTE]
> Only for system user accounts. Read more about [system user accounts][1].

## Functions

| Function  | Purpose            | Comment                         |
|-----------|--------------------|---------------------------------|
| Delete    | Delete multiple rows by primary key | More efficient that deleting rows one by one, less efficient than truncate. |
| Insert    | Add new rows.      | No primary key (needs to be) specified, all rows are simply added. Any collision with unique indexes causes an exception. |
| Truncate  | Delete all rows in table, reset next primary key value to 1 | Unconditional and non-recoverable (even at Sql Server level) truncation of table. Very fast, near-instant. |
| Upsert    | Add or update rows, by key | User-defined key column designates target rows. Input rows that have no key match cause an **insert**. Key match causes an update of designated columns |

> [!NOTE]
> Target Table – any except blacklisted tables are acceptable.

## Data format

For the insert and upsert functions, the data are in a rectangular, two-dimensional array of values. A separate property contains an array of field names.   Each cell contains the data in the format used by our CultureDataFormatter serialization, ensuring an unambiguous interpretation.

### Field Names

<style type="text/css">
.tg  {border-collapse:collapse;border-spacing:0;margin:0px auto;}
.tg td{border-color:black;border-style:solid;border-width:1px;font-family:Arial, sans-serif;font-size:14px;
  overflow:hidden;padding:10px 5px;word-break:normal;}
.tg th{border-color:black;border-style:solid;border-width:1px;font-family:Arial, sans-serif;font-size:14px;
  font-weight:normal;overflow:hidden;padding:10px 5px;word-break:normal;}
.tg .tg-0lax{text-align:left;vertical-align:top}
@media screen and (max-width: 767px) {.tg {width: auto !important;}.tg col {width: auto !important;}.tg-wrap {overflow-x: auto;-webkit-overflow-scrolling: touch;margin: auto 0px;}}</style>
<div class="tg-wrap"><table class="tg">
<thead>
  <tr>
    <th class="tg-0pky">"x_name"</th>
    <th class="tg-0pky">"x_description"</th>
    <th class="tg-0lax">"x_price"</th>
    <th class="tg-0lax">""x_weight"</th>
  </tr>
</thead>
</table><div>

### Field Values

<style type="text/css">
.tg  {border-collapse:collapse;border-spacing:0;margin:0px auto;}
.tg td{border-color:black;border-style:solid;border-width:1px;font-family:Arial, sans-serif;font-size:14px;
  overflow:hidden;padding:10px 5px;word-break:normal;}
.tg th{border-color:black;border-style:solid;border-width:1px;font-family:Arial, sans-serif;font-size:14px;
  font-weight:normal;overflow:hidden;padding:10px 5px;word-break:normal;}
.tg .tg-0lax{text-align:left;vertical-align:top}
@media screen and (max-width: 767px) {.tg {width: auto !important;}.tg col {width: auto !important;}.tg-wrap {overflow-x: auto;-webkit-overflow-scrolling: touch;margin: auto 0px;}}</style>
<div class="tg-wrap"><table class="tg">
<tbody>
  <tr>
    <td class="tg-0lax">"cat"</td>
    <td class="tg-0lax">"in a hat"</td>
    <td class="tg-0lax">123</td>
    <td class="tg-0lax">4.5</td>
  </tr>
  <tr>
    <td class="tg-0lax">"Foozle"</td>
    <td class="tg-0lax">"Not woozels"</td>
    <td class="tg-0lax">"[I:123]"</td>
    <td class="tg-0lax">"[F:4.56]"</td>
  </tr>
  <tr>
    <td class="tg-0lax">"Screwdriver"</td>
    <td class="tg-0lax">"Philips head"</td>
    <td class="tg-0lax">"[I:69]"</td>
    <td class="tg-0lax">42</td>
  </tr>
</tbody>
</table></div>

CultureDataFormatter accepts un-encoded values also, as a convenience, but beware of date-time formatting pain.

## Webhooks and TravelTransactionLog

We currently do not have webhook events defined for extratables; nor are those tables logged in traveltransactionlog.

Both extratables and ordinary system tables can be changed by the mass operations. When system tables are changed by Upsert or Delete, the proper webhooks will be fired, row by row. Logging into traveltransactionlog will also happen in the usual fashion.

#### Example:

We Upsert 4 rows on contact: 3 inserts and 1 update.  
This results in 4 webhook calls: 3 contact.created events, 1 contact.changed event.

We Upsert 4 rows on extra table y_bicycle: 3 inserts and 1 update.  

This results in 0 webhook calls: extra tables do not have webhooks (yet).

## Methods

### Insert

Insert may or may not specify primary keys. If the primary key column is not specified in the field name array, all rows will have primary key values allocated according to standard methods. If the primary key column is specified, blank and [I:0] cells indicate that a primary key should be allocated; other integer values are used as-is. If there is a collision, the operation aborts.

```c#
Insert(string tableName, string[] fieldNames, object[][] data) 
```

# [REST](#tab/insert-1)

#### REST API Insert

```http
POST /api/v1/Table/y_foobar 

{ 
  fields: [ "x_col_a", "x_col_b" ],
  data: [[ "x", 123 ], ["y", 234], ["z", 345], ["æ", 456] ] 
} 
```

# [Agent](#tab/insert-2)

#### Agent API Insert

[!code-csharp[CS](../includes/mass-operation-insert.cs)]

***

This will insert 4 rows into the y_foobar table. Other unspecified columns in the table will be set to default values. The primary key y_foobar.id will be automatically allocated by the database (since extra tables does not use sequence, but auto-increment).

Nullable fields are defaulted if not specified. Not-Null fields must be specified.

Bulk inserts, updates and deletes cannot be wrapped in transactions, because the logging volumes and locks would simply be too great. In addition, there are problems with Connection Pooling and limitations on what operations can be enlisted in transactions in the first place.

Therefore, a failed Upsert can leave the database in a partially updated state. There is extensive validation to catch things like badly formatted fields or too-long strings before anything is updated, but there are ultimately no guarantees. Similarly, trying to queue millions of webhook callouts may cause an OutOfMemory exception partway through the process.

Errors are returned as a Bad Request error with an explanatory exception text that generally tries to pinpoint the problem, row and column.

### Upsert

This method has three main parameters: An array of field names to be updated; an array of field names that together constitute a unique key for identifying rows; and a matrix of values with both the key and data fields specified for each row. In addition, one can specify the action to be taken for unmatched rows, and how much return information is desired (detailed row-by-row status takes time and resources).

# [REST](#tab/Upsert-1)



# [Agent](#tab/Upsert-2)

***

```c#
Upsert(string tableName, string[] fieldNamesToUpdate, string[] keyFieldNames, object[][] data)
```

The key field may be the database primary key, but it can also be any other (combination of) field(s) that uniquely identifies a row. If the combination of values in an input row does not match any rows in the database, an insert operation results; otherwise the matching row is updated. If there is a multiple match, the operation is aborted. [or should we use this as a way of allow multiple rows to be efficiently updated to the same values?]

# [REST](#tab/upsert-1)
#### REST API Upsert

```javascript
PUT /api/v1/Table/y_foobar 

{ 
  fields: [ "id", "x_col_a", "x_col_b" ], 
  key: [ "id" ], 
  data: [[0, "x", 123], [42, "y", 234], [null, "z", 345], [0,"æ",456]] 
} 
```

# [Agent](#tab/upsert-2)

#### Agent API Upsert

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

### Truncate

All rows in the table are deleted using TRUNCATE TABLE or a corresponding SQL commands. This is typically an irrecoverable deletion of all rows in the table. It is extremely fast and almost independent of table size.

#### REST API Truncate

```http
DELETE /api/v1/Table/y_foobar 
```

This will truncate the whole table, but won"t delete the table itself. (That would be a schema change, and is handled elsewhere).

Truncate is only allowed on extra tables. Attempts to truncate built-in tables like Contact or Person will fail with not-allowed error.

### Delete

The specified rows are deleted in an efficient way, subject to Sentry permissions. The time taken is proportional to the number of rows deleted.

```c#
BulkDelete(string tableName, int[] primaryKeys) 
```

#### REST API Delete

```http
DELETE /api/v1/Table/y_foobar/1,2,3,5,8,13,21 
```

This will delete the specified rows from the table. A URL is typically allowed to be somewhere between 1 and 4kB – so the REST API could accept 250 to 1000 ids per call.

Bulk Delete is allowed on extra tables and on the built-in tables.

<!-- Referenced links -->
[1]: ../../../superoffice-docs/docs/authentication/system-user/index.md