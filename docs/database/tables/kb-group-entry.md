---
uid: table-kb-group-entry
title: kb\_group\_entry table
description: This table contains group entries for FAQ groups.
so.generated: true
keywords:
  - "database"
  - "kb_group_entry"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# kb\_group\_entry Table (287)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|kb\_group\_id|The id of the group in which this entry is located.|FK [kb-group](kb-group.md)| |
|kb\_entry\_id|The id of the kb_entry this entry references.|FK [kb-entry](kb-entry.md)| |
|sort\_pos|A number (strictly ascending) indicating the sorted position for this element.|Int|&#x25CF;|


![kb_group_entry table relationship diagram](./media/kb_group_entry.png)

[!include[details](./includes/kb-group-entry.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|kb\_group\_id |FK |Index |
|kb\_entry\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

