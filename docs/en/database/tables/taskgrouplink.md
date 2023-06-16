---
uid: table-TaskGroupLink
title: TaskGroupLink table
description: User group link table for Task, for MDO item hiding
so.generated: true
keywords: database table TaskGroupLink
so.topic: reference
so.envir: onsite, online
---

# TaskGroupLink Table (68)

User group link table for Task, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|taskgrouplink\_id|Primary key|PK| |
|task\_id|Link to Task list table|FK [Task](task.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![TaskGroupLink table relationship diagram](./media/TaskGroupLink.png)

[!include[details](./includes/taskgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|taskgrouplink\_id |PK |Clustered, Unique |
|task\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Task](task.md)  |Task list table, activity types, like Phone, Meeting |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

