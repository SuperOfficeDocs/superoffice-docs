---
uid: table-kb-category-log
title: kb\_category\_log table
description: Who and when, if somebody edits a knowledge base folder
so.generated: true
keywords:
  - "database"
  - "kb_category_log"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# kb\_category\_log Table (291)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|kb\_category\_id|The id of the kb_category that triggered this action.|FK [kb-category](kb-category.md)| |
|user\_id|The id of the user that created this comment.|FK [ejuser](ejuser.md)| |
|log\_when|When the action occured.|DateTime|&#x25CF;|


![kb_category_log table relationship diagram](./media/kb_category_log.png)

[!include[details](./includes/kb-category-log.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|kb\_category\_id |FK |Index |
|user\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

