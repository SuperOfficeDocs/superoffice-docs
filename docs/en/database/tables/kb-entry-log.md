---
uid: table-kb_entry_log
title: kb_entry_log table
description: Who and when, if somebody edits a knowledge base entry
so.generated: true
keywords: database table kb_entry_log
so.topic: reference
so.envir: onsite, online
---

# kb\_entry\_log Table (290)

Who and when, if somebody edits a knowledge base entry

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|kb\_entry\_id|The id of the kb_entry that triggered this action.|FK [kb_entry](kb-entry.md)| |
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

## Relationships

| Table|  Description |
|------|-------------|
|[ejuser](ejuser.md)  |This table contains entries for the users of the system. |
|[kb\_entry](kb-entry.md)  |This table contains FAQ entries. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

