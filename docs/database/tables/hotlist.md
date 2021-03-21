---
uid: table-hotlist
title: hotlist table
description: The table is used by the hotlist to store the relationship between tickets and users
so.generated: true
keywords:
  - "database"
  - "hotlist"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# hotlist Table (363)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|user\_id|The reference to the user.|FK [ejuser](ejuser.md)| |
|ticket\_id|The ticket the user what to have in his hotlist|FK [ticket](ticket.md)| |


![hotlist table relationship diagram](./media/hotlist.png)

[!include[details](./includes/hotlist.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|user\_id |FK |Index |
|ticket\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

