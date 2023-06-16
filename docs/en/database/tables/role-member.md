---
uid: table-role_member
title: role_member table
description: Users linked to a role. Deprecated.
so.generated: true
keywords: database table role_member
so.topic: reference
so.envir: onsite, online
---

# role\_member Table (324)

Users linked to a role. Deprecated.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|role|The id of the group.|FK [ej_role](ej-role.md)| |
|ejuser|The id of the user.|FK [ejuser](ejuser.md)| |


![role_member table relationship diagram](./media/role_member.png)

[!include[details](./includes/role-member.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|role |FK |Index |
|ejuser |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[ej\_role](ej-role.md)  |Define access rights, memberships and other properties for role user members |
|[ejuser](ejuser.md)  |This table contains entries for the users of the system. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

