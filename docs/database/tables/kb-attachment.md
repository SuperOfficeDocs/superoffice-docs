---
uid: table-kb-attachment
title: kb\_attachment table
description: This table connects FAQ entries to attachments.
so.generated: true
keywords:
  - "database"
  - "kb_attachment"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# kb\_attachment Table (284)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|entry\_id|The id of the corresponding kb_entry.|FK [kb-entry](kb-entry.md)| |
|attachment\_id|The id of the corresponding kb_category.|FK [attachment](attachment.md)| |


![kb_attachment table relationship diagram](./media/kb_attachment.png)

[!include[details](./includes/kb-attachment.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|entry\_id |FK |Index |
|attachment\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

