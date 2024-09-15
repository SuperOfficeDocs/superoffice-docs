---
uid: table-PriorityGroupLink
title: PriorityGroupLink table
description: User group link table for Priority, for MDO item hiding
so.generated: true
keywords: database table PriorityGroupLink
so.topic: reference
so.envir: onsite, online
---

# PriorityGroupLink Table (80)

User group link table for Priority, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|prioritygrouplink\_id|Primary key|PK| |
|priority\_id|Link to Priority list table|FK [Priority](priority.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PriorityGroupLink table relationship diagram](./media/PriorityGroupLink.png)

[!include[details](./includes/prioritygrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|prioritygrouplink\_id |PK |Clustered, Unique |
|priority\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Priority](priority.md)  |Priority list table. Used with appointments: low, high. |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

