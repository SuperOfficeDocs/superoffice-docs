---
uid: contintgrouplink
title: contintgrouplink table
description: User group link table for ContInt, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "contintgrouplink"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ContIntGroupLink Table (71)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|contintgrouplink\_id|Primary key|PK| |
|contint\_id|Link to ContInt list table|FK [ContInt](ContInt.md)| |
|group\_id|Link to Group table|FK [UserGroup](UserGroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ContIntGroupLink table relationship diagram](media\ContIntGroupLink.png)

[!include[details](./includes/ContIntGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|contintgrouplink\_id |PK |Clustered, Unique |
|contint\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

