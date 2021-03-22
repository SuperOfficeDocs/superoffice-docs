---
uid: table-extra-tables-entry
title: extra\_tables\_entry table
description: Hits/entries in result set of executed search in ejournal extra tables
so.generated: true
keywords:
  - "database"
  - "extra_tables_entry"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# extra\_tables\_entry Table (309)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|extra\_tables\_result|The id of the result.|FK [extra-tables-result](extra-tables-result.md)| |
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

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

