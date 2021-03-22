---
uid: table-persposgrouplink
title: persposgrouplink table
description: User group link table for PersPos, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "PersPosGroupLink"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# persposgrouplink Table (77)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|persposgrouplink\_id|Primary key|PK| |
|perspos\_id|Link to PersPos list table|FK [perspos](perspos.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PersPosGroupLink table relationship diagram](./media/PersPosGroupLink.png)

[!include[details](./includes/PersPosGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|persposgrouplink\_id |PK |Clustered, Unique |
|perspos\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

