---
uid: table-ReasonSoldGroupLink
title: ReasonSoldGroupLink table
description: User group link table for ReasonSold, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "ReasonSoldGroupLink"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ReasonSoldGroupLink Table (116)

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

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

