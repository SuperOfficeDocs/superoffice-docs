---
uid: table-role-category
title: role\_category table
description: Category membership associated with a role
so.generated: true
keywords:
  - "database"
  - "role_category"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# role\_category Table (325)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|role|The id of the group. Deprecated.|FK [ej-role](ej-role.md)| |
|category|The id of the category.|FK [ej-category](ej-category.md)| |
|crm\_role|Link to Role|FK [role](role.md)|&#x25CF;|


![role_category table relationship diagram](./media/role_category.png)

[!include[details](./includes/role-category.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|role |FK |Index |
|category |FK |Index |
|crm\_role |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

