---
uid: table-amountclassgrouplink
title: amountclassgrouplink table
description: User group link table for AmountClass, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "AmountClassGroupLink"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# amountclassgrouplink Table (226)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|amountclassgrouplink\_id|Primary key|PK| |
|amountclass\_id|Link to AmountClass list table|FK [amountclass](amountclass.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![AmountClassGroupLink table relationship diagram](./media/AmountClassGroupLink.png)

[!include[details](./includes/AmountClassGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|amountclassgrouplink\_id |PK |Clustered, Unique |
|amountclass\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

