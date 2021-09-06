---
uid: table-kb-workflow-access
title: kb\_workflow\_access table
description: Control of who can do what in a knowledge base workflow step
so.generated: true
keywords:
  - "database"
  - "kb_workflow_access"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# kb\_workflow\_access Table (293)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|kb\_workflow|The workflow to access.|FK [kb-workflow](kb-workflow.md)| |
|user\_id|The user with access.|FK [ejuser](ejuser.md)| |
|kb\_access|The access given to a user for entries in a given workflow phase. 1 for viewing entries, 2 for moving entries between workflow phases, 3 for editing entries|kb-access| |


![kb_workflow_access table relationship diagram](./media/kb_workflow_access.png)

[!include[details](./includes/kb-workflow-access.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|kb\_workflow |FK |Index |
|user\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

