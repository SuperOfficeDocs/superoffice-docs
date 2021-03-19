---
uid: reldefgrouplink
title: reldefgrouplink table
description: User group link table for RelDef, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "reldefgrouplink"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# RelDefGroupLink Table (49)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|reldefgrouplink\_id|Primary key|PK| |
|reldef\_id|Link to RelDef list table|FK [relationdefinition](relationdefinition.md)| |
|group\_id|Link to Group table|FK [UserGroup](UserGroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![RelDefGroupLink table relationship diagram](media\RelDefGroupLink.png)

[!include[details](./includes/RelDefGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|reldefgrouplink\_id |PK |Clustered, Unique |
|reldef\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

