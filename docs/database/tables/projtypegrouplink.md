---
uid: projtypegrouplink
title: projtypegrouplink table
description: User group link table for ProjType, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "projtypegrouplink"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ProjTypeGroupLink Table (86)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|projtypegrouplink\_id|Primary key|PK| |
|projtype\_id|Link to ProjType list table|FK [ProjType](ProjType.md)| |
|group\_id|Link to Group table|FK [UserGroup](UserGroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProjTypeGroupLink table relationship diagram](media\ProjTypeGroupLink.png)

[!include[details](./includes/ProjTypeGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|projtypegrouplink\_id |PK |Clustered, Unique |
|projtype\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

