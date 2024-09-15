---
uid: table-extra_tables_entry
title: extra_tables_entry table
description: Hits/entries in result set of executed search in ejournal extra tables
so.generated: true
keywords: database table extra_tables_entry
so.topic: reference
so.envir: onsite, online
---

# extra\_tables\_entry Table (309)

Hits/entries in result set of executed search in ejournal extra tables

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|extra\_tables\_result|The id of the result.|FK [extra_tables_result](extra-tables-result.md)| |
|entry\_id|The id of the entry in the extra table.|Int|&#x25CF;|
|prev\_id|The id of the entry in the extra table.|Int|&#x25CF;|
|next\_id|The id of the entry in the extra table.|Int|&#x25CF;|
|page\_num|The pagenum of this result entry in the table.|Int|&#x25CF;|
|order\_pos|Used to order elements when listed.|Int|&#x25CF;|


![extra_tables_entry table relationship diagram](./media/extra_tables_entry.png)

[!include[details](./includes/extra-tables-entry.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|extra\_tables\_result |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[extra\_tables\_result](extra-tables-result.md)  |Result set of executed search in ejournal extra tables |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

