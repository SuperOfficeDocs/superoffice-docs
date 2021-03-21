---
uid: table-sourcegrouplink
title: sourcegrouplink table
description: User group link table for Source, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "SourceGroupLink"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# sourcegrouplink Table (101)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|sourcegrouplink\_id|Primary key|PK| |
|source\_id|Link to Source list table|FK [source](source.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SourceGroupLink table relationship diagram](./media/SourceGroupLink.png)

[!include[details](./includes/SourceGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|sourcegrouplink\_id |PK |Clustered, Unique |
|source\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

