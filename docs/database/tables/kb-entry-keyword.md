---
uid: table-kb_entry_keyword
title: kb_entry_keyword table
description: This table contains all keywords for the faq entries
so.generated: true
keywords:
  - "database"
  - "kb_entry_keyword"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# kb\_entry\_keyword Table (288)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|kb\_entry\_id|The id of the kb_entry which this keyword belongs to.|FK [kb_entry](kb-entry.md)| |
|keyword|A keyword for the given entry.|String(255)| |


![kb_entry_keyword table relationship diagram](./media/kb_entry_keyword.png)

[!include[details](./includes/kb-entry-keyword.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|kb\_entry\_id |FK |Index |
|keyword |String(255) |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

