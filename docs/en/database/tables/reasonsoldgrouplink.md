---
uid: table-ReasonSoldGroupLink
title: ReasonSoldGroupLink table
description: User group link table for ReasonSold, for MDO item hiding
so.generated: true
keywords: database table ReasonSoldGroupLink
so.topic: reference
so.envir: onsite, online
---

# ReasonSoldGroupLink Table (116)

User group link table for ReasonSold, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|reasonsoldgrouplink\_id|Primary key|PK| |
|reasonsold\_id|Link to ReasonSold list table|FK [ReasonSold](reasonsold.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ReasonSoldGroupLink table relationship diagram](./media/ReasonSoldGroupLink.png)

[!include[details](./includes/reasonsoldgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|reasonsoldgrouplink\_id |PK |Clustered, Unique |
|reasonsold\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ReasonSold](reasonsold.md)  |Why was the sale marked as sold (why did we succeed) |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

