---
uid: table-kb-http-link
title: kb\_http\_link table
description: This table contains URL&amp;apos;s associated with a single FAQ entry.
so.generated: true
keywords:
  - "database"
  - "kb_http_link"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# kb\_http\_link Table (285)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|entry\_id|The id of the kb entry this entry is connected to.|FK [kb-entry](kb-entry.md)| |
|name|The name for this link.|String(255)| |
|http\_link|The URL for this link.|String(255)| |


![kb_http_link table relationship diagram](./media/kb_http_link.png)

[!include[details](./includes/kb-http-link.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|entry\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

