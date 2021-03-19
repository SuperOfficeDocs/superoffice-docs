---
uid: udlistgrouplink
title: udlistgrouplink table
description: User group link table for UDList, for MDO item hiding. Note - MDO mode for userdefinede lists are either turned on or off, you may not have it on for one userdefined list and off for the others.
so.generated: true
keywords:
  - "database"
  - "udlistgrouplink"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# UDListGroupLink Table (137)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|udlistgrouplink\_id|Primary key|PK| |
|udlist\_id|Link to UDList list table|FK [UDList](UDList.md)| |
|group\_id|Link to Group table|FK [UserGroup](UserGroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![UDListGroupLink table relationship diagram](media\UDListGroupLink.png)

[!include[details](./includes/UDListGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|udlistgrouplink\_id |PK |Clustered, Unique |
|udlist\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

