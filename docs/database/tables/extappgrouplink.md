---
uid: table-extappgrouplink
title: extappgrouplink table
description: User group link table for ExtApp, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "ExtAppGroupLink"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# extappgrouplink Table (134)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|extappgrouplink\_id|Primary key|PK| |
|extapp\_id|Link to ExtApp list table|FK [extapp](extapp.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ExtAppGroupLink table relationship diagram](./media/ExtAppGroupLink.png)

[!include[details](./includes/ExtAppGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|extappgrouplink\_id |PK |Clustered, Unique |
|extapp\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

