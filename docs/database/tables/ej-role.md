---
uid: table-ej-role
title: ej\_role table
description: Define access rights, memberships and other properties for role user members
so.generated: true
keywords:
  - "database"
  - "ej_role"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ej\_role Table (323)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|name|This is the name of the role|String(255)|&#x25CF;|
|use\_user\_group|Override user user group with role|Bool|&#x25CF;|
|user\_group|The group this user is member of |FK [hierarchy](hierarchy.md)| |
|access\_mask|Access mask for users using this role|Int|&#x25CF;|
|access\_values|Access values for users using this role|Int|&#x25CF;|
|use\_categories|Override user categories with role categories|Bool|&#x25CF;|


![ej_role table relationship diagram](./media/ej_role.png)

[!include[details](./includes/ej-role.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|user\_group |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

