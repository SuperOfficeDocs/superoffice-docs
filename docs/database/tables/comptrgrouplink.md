---
uid: table-ComptrGroupLink
title: ComptrGroupLink table
description: User group link table for Comptr, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "ComptrGroupLink"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ComptrGroupLink Table (110)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|comptrgrouplink\_id|Primary key|PK| |
|comptr\_id|Link to Comptr list table|FK [Comptr](comptr.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ComptrGroupLink table relationship diagram](./media/ComptrGroupLink.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|comptrgrouplink\_id |PK |Clustered, Unique |
|comptr\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

