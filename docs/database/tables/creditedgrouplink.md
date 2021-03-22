---
uid: table-creditedgrouplink
title: creditedgrouplink table
description: User group link table for Credited, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "CreditedGroupLink"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# creditedgrouplink Table (98)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|creditedgrouplink\_id|Primary key|PK| |
|credited\_id|Link to Credited list table|FK [credited](credited.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![CreditedGroupLink table relationship diagram](./media/CreditedGroupLink.png)

[!include[details](./includes/CreditedGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|creditedgrouplink\_id |PK |Clustered, Unique |
|credited\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

