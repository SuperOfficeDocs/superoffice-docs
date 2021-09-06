---
uid: table-associategrouplink
title: associategrouplink table
description: User group link table for Associate, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "AssociateGroupLink"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# associategrouplink Table (3)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|associategrouplink\_id|Primary key|PK| |
|associate\_id|Link to Associate list table|FK [associate](associate.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![AssociateGroupLink table relationship diagram](./media/AssociateGroupLink.png)

[!include[details](./includes/AssociateGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|associategrouplink\_id |PK |Clustered, Unique |
|associate\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

