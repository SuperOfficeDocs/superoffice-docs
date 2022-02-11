---
uid: table-role_workflow
title: role_workflow table
description: Knowledge base workflow access rights associated with a role
so.generated: true
keywords:
  - "database"
  - "role_workflow"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# role\_workflow Table (327)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|role|The id of the group. Deprecated.|FK [ej_role](ej-role.md)| |
|workflow\_id|The id of the workflow.|FK [kb_workflow](kb-workflow.md)| |
|workflow\_access|The access level.|Int|&#x25CF;|
|crm\_role|Link to Role|FK [Role](role.md)|&#x25CF;|


![role_workflow table relationship diagram](./media/role_workflow.png)

[!include[details](./includes/role-workflow.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|role |FK |Index |
|workflow\_id |FK |Index |
|crm\_role |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

