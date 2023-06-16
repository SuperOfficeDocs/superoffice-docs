---
uid: table-ext_field
title: ext_field table
description: This table contains entries mapping an external field to an internal field. Used for database integration.
so.generated: true
keywords: database table ext_field
so.topic: reference
so.envir: onsite, online
---

# ext\_field Table (319)

This table contains entries mapping an external field to an internal field. Used for database integration.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|ext\_table|The reference to the associated ext_table|FK [ext_table](ext-table.md)|&#x25CF;|
|seq\_order|The column number for this field. Strictly ascending.|Int|&#x25CF;|
|name|The name for this field.|String(255)|&#x25CF;|
|target|The target for this field. E.g. &amp;apos;customer.name&amp;apos;. |String(64)|&#x25CF;|
|flags|Bitmap for flags for this entry.|Int|&#x25CF;|
|datatype|The datatype for this field. TODO: depreciated?|Int|&#x25CF;|


![ext_field table relationship diagram](./media/ext_field.png)

[!include[details](./includes/ext-field.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|ext\_table |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[ext\_table](ext-table.md)  |This table contains entries used for mapping an external table to an internal table (customer or cust_company) for database integration. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

