---
uid: table-kb_attachment
title: kb_attachment table
description: This table connects FAQ entries to attachments.
so.generated: true
keywords: database table kb_attachment
so.topic: reference
so.envir: onsite, online
---

# kb\_attachment Table (284)

This table connects FAQ entries to attachments.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|entry\_id|The id of the corresponding kb_entry.|FK [kb_entry](kb-entry.md)| |
|attachment\_id|The id of the corresponding kb_category.|FK [attachment](attachment.md)| |


![kb_attachment table relationship diagram](./media/kb_attachment.png)

[!include[details](./includes/kb-attachment.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|entry\_id |FK |Index |
|attachment\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[attachment](attachment.md)  |This table contains metadata for attachments. The actual attachments are stored directly on disk, with filenames based on the the primary key for this table. |
|[kb\_entry](kb-entry.md)  |This table contains FAQ entries. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

