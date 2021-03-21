---
uid: table-access-script
title: access\_script table
description: Scripts to implement row-based access rules (sentry light)
so.generated: true
keywords:
  - "database"
  - "access_script"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# access\_script Table (406)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|access\_table\_name|The name of the table that the access_script is connected to|String(255)| |
|body|The ejscript that limits the access to the according table|Clob|&#x25CF;|


![access_script table relationship diagram](./media/access_script.png)

[!include[details](./includes/access-script.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

