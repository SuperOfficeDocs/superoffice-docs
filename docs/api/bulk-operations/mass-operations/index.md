---
title: Mass Operations
description: How to change large numbers of records in bulk.
author: AnthonyYates             # Your GitHub alias.
so.date: 29.02.2021
keywords: data-access, bulk-update
version: 9.2 R04
---

# Mass Operations

SuperOffice APIs supports the import and update of large datasets via the Mass Operations API. These APIs leverage target database server bulk copy features and are therefore optimized for speed.

Mass Operation functions are intentionally generic, and operate towards one table at a time. To be fast, mass operations must bypass all sentry security checks and therefore require an authenticated system user accounts to work.

> [!NOTE]
> Must be a system user. Read more about [system user accounts][1].
> Supported database servers are SQL Server and Oracle. Oracle does not support the `Upsert` method.

## MassOperation API Functions

| Function  | Purpose            | Comment                         |
|-----------|--------------------|---------------------------------|
| [Delete](delete.md)    | Delete multiple rows by primary key | More efficient that deleting rows one by one, less efficient than truncate. |
| [Insert](insert.md)    | Add new rows.      | No primary key (needs to be) specified, all rows are simply added. Any collision with unique indexes causes an exception. |
| [Truncate](truncate.md)  | Delete all rows in table, reset next primary key value to 1 | Unconditional and non-recoverable truncation of table. Very fast, near-instant. |
| [Upsert](upsert.md)    | Add or update rows, by key | Key column(s) designate target rows. Rows that have *no* key match are treated as **insert** rows. |

> [!NOTE]
> Mass operations do not work on these [protected-tables](invalid-tables.md).

## Working with Mass Operations

The data format used by our CultureDataFormatter serialization, ensuring an unambiguous interpretation.

Use `CultureDataFormatter.Encode(object)` to format non-string values.

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

Nullable fields are defaulted if not specified. Not-Null fields must be specified.

Errors are returned as a Bad Request error with an explanatory exception text that generally tries to pinpoint the problem, row and column.

<!-- Referenced links -->
[1]: ../../../superoffice-docs/docs/authentication/system-user/index.md