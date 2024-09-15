---
uid: table-SaleTypeCatGroupLink
title: SaleTypeCatGroupLink table
description: User group link table for SaleTypeCat, for MDO item hiding
so.generated: true
keywords: database table SaleTypeCatGroupLink
so.topic: reference
so.envir: onsite, online
---

# SaleTypeCatGroupLink Table (119)

User group link table for SaleTypeCat, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|saletypecatgrouplink\_id|Primary key|PK| |
|saletypecat\_id|Link to SaleTypeCat list table|FK [SaleTypeCat](saletypecat.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SaleTypeCatGroupLink table relationship diagram](./media/SaleTypeCatGroupLink.png)

[!include[details](./includes/saletypecatgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|saletypecatgrouplink\_id |PK |Clustered, Unique |
|saletypecat\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[SaleTypeCat](saletypecat.md)  |Category for sale type |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

