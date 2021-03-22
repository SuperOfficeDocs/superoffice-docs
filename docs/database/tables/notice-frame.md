---
uid: table-notice-frame
title: notice\_frame table
description: PID controller for automatic adjustment of pop up message check rate
so.generated: true
keywords:
  - "database"
  - "notice_frame"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# notice\_frame Table (404)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|error\_p|PID error P|Double| |
|error\_i|PID error I|Double| |
|error\_d|PID error D|Double| |
|t0|Last executing|Double| |
|average\_dt|Average dt|Double| |
|refresh\_rate|Notice frame refresh rate|Double| |


![notice_frame table relationship diagram](./media/notice_frame.png)

[!include[details](./includes/notice-frame.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

