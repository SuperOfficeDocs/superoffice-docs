---
uid: table-BusinessGroupLink
title: BusinessGroupLink table
description: User group link table for Business, for MDO item hiding
so.generated: true
keywords: database table BusinessGroupLink
so.topic: reference
so.envir: onsite, online
---

# BusinessGroupLink Table (62)

User group link table for Business, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|businessgrouplink\_id|Primary key|PK| |
|business\_id|Link to Business list table|FK [Business](business.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![BusinessGroupLink table relationship diagram](./media/BusinessGroupLink.png)

[!include[details](./includes/businessgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|businessgrouplink\_id |PK |Clustered, Unique |
|business\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Business](business.md)  |Business list table |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

