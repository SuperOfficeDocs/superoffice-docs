---
uid: table-MrMrsGroupLink
title: MrMrsGroupLink table
description: User group link table for MrMrs, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "MrMrsGroupLink"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# MrMrsGroupLink Table (95)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|mrmrsgrouplink\_id|Primary key|PK| |
|mrmrs\_id|Link to MrMrs list table|FK [MrMrs](mrmrs.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![MrMrsGroupLink table relationship diagram](./media/MrMrsGroupLink.png)

[!include[details](./includes/mrmrsgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|mrmrsgrouplink\_id |PK |Clustered, Unique |
|mrmrs\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

