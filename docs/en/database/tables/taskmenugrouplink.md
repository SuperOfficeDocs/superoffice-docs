---
uid: table-TaskMenuGroupLink
title: TaskMenuGroupLink table
description: User group link table for TaskMenu, for MDO item hiding
so.generated: true
keywords: database table TaskMenuGroupLink
so.topic: reference
so.envir: onsite, online
---

# TaskMenuGroupLink Table (467)

User group link table for TaskMenu, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|taskmenugrouplink\_id|Primary key|PK| |
|taskMenu\_id|Link to TaskMenu list table|FK [TaskMenu](taskmenu.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![TaskMenuGroupLink table relationship diagram](./media/TaskMenuGroupLink.png)

[!include[details](./includes/taskmenugrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|taskmenugrouplink\_id |PK |Clustered, Unique |
|taskMenu\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[TaskMenu](taskmenu.md)  |List items to merge into menues |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

