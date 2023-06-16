---
uid: table-kb_group_entry
title: kb_group_entry table
description: This table contains group entries for FAQ groups.
so.generated: true
keywords: database table kb_group_entry
so.topic: reference
so.envir: onsite, online
---

# kb\_group\_entry Table (287)

This table contains group entries for FAQ groups.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|kb\_group\_id|The id of the group in which this entry is located.|FK [kb_group](kb-group.md)| |
|kb\_entry\_id|The id of the kb_entry this entry references.|FK [kb_entry](kb-entry.md)| |
|sort\_pos|A number (strictly ascending) indicating the sorted position for this element.|Int|&#x25CF;|


![kb_group_entry table relationship diagram](./media/kb_group_entry.png)

[!include[details](./includes/kb-group-entry.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|kb\_group\_id |FK |Index |
|kb\_entry\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[kb\_entry](kb-entry.md)  |This table contains FAQ entries. |
|[kb\_group](kb-group.md)  |This table contains FAQ groups. A group is a cluster of entries (potentially located anywhere in the FAQ hierarchy). A group is located in a certain category. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

