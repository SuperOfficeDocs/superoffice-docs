---
uid: table-ReasonStalledGroupLink
title: ReasonStalledGroupLink table
description: Link table for ReasonStalled, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "ReasonStalledGroupLink"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ReasonStalledGroupLink Table (155)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|reasonstalledgrouplink\_id|Primary key|PK| |
|reasonstalled\_id|Link to ReasonStalled list table|FK [ReasonStalled](reasonstalled.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ReasonStalledGroupLink table relationship diagram](./media/ReasonStalledGroupLink.png)

[!include[details](./includes/reasonstalledgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|reasonstalledgrouplink\_id |PK |Clustered, Unique |
|reasonstalled\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

