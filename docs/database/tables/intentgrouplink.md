---
uid: table-intentgrouplink
title: intentgrouplink table
description: User group link table for Intent, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "IntentGroupLink"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# intentgrouplink Table (217)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|intentgrouplink\_id|Primary key|PK| |
|intent\_id|Link to Intent list table|FK [intent](intent.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![IntentGroupLink table relationship diagram](./media/IntentGroupLink.png)

[!include[details](./includes/IntentGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|intentgrouplink\_id |PK |Clustered, Unique |
|intent\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

