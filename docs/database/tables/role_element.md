---
uid: role_element
title: role_element table
description: Profiles associated with a role
so.generated: true
keywords:
  - "database"
  - "role_element"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# RoleElement Table (326)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|role|The id of the group. Deprecated.|FK [ej_role](ej_role.md)| |
|element\_profile|The id of the element_profile.|FK [element_profile](element_profile.md)| |
|crm\_role|Link to Role|FK [Role](Role.md)|&#x25CF;|


![role_element table relationship diagram](media\role_element.png)

[!include[details](./includes/role-element.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|role |FK |Index |
|element\_profile |FK |Index |
|crm\_role |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

