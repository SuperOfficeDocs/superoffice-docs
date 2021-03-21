---
uid: table-kb-entry-log
title: kb\_entry\_log table
description: Who and when, if somebody edits a knowledge base entry
so.generated: true
keywords:
  - "database"
  - "kb_entry_log"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# kb\_entry\_log Table (290)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|kb\_entry\_id|The id of the kb_entry that triggered this action.|FK [kb-entry](kb-entry.md)| |
|user\_id|The id of the user that created this comment.|FK [ejuser](ejuser.md)| |
|log\_when|When the action occured.|DateTime|&#x25CF;|


![kb_entry_log table relationship diagram](./media/kb_entry_log.png)

[!include[details](./includes/kb-entry-log.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|kb\_entry\_id |FK |Index |
|user\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

