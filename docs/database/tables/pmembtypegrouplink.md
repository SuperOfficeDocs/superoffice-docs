---
uid: table-pmembtypegrouplink
title: pmembtypegrouplink table
description: User group link table for PMembType, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "PMembTypeGroupLink"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# pmembtypegrouplink Table (92)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|pmembtypegrouplink\_id|Primary key|PK| |
|pmembtype\_id|Link to PMembType list table|FK [pmembtype](pmembtype.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PMembTypeGroupLink table relationship diagram](./media/PMembTypeGroupLink.png)

[!include[details](./includes/PMembTypeGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|pmembtypegrouplink\_id |PK |Clustered, Unique |
|pmembtype\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

