---
uid: table-extra_tables_result
title: extra_tables_result table
description: Result set of executed search in ejournal extra tables
so.generated: true
keywords:
  - "database"
  - "extra_tables_result"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# extra\_tables\_result Table (308)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|login\_id|The id of the login session this result set belongs to.|FK [login](login.md)| |
|extra\_table|The id of the extra table.|FK [extra_tables](extra-tables.md)| |
|num\_entries|The number of results.|Int|&#x25CF;|
|active\_page|The current active page.|Int|&#x25CF;|


![extra_tables_result table relationship diagram](./media/extra_tables_result.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|login\_id |FK |Index |
|extra\_table |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

