---
uid: table-role_member
title: role_member table
description: Users linked to a role. Deprecated.
so.generated: true
keywords:
  - "database"
  - "role_member"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# role\_member Table (324)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|role|The id of the group.|FK [ej_role](ej-role.md)| |
|ejuser|The id of the user.|FK [ejuser](ejuser.md)| |


![role_member table relationship diagram](./media/role_member.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|role |FK |Index |
|ejuser |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

