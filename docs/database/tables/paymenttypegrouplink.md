---
uid: table-paymenttypegrouplink
title: paymenttypegrouplink table
description: User group link table for PaymentType, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "PaymentTypeGroupLink"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# paymenttypegrouplink Table (431)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|paymenttypegrouplink\_id|Primary key|PK| |
|paymenttype\_id|Link to PaymentType list table|FK [paymenttype](paymenttype.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PaymentTypeGroupLink table relationship diagram](./media/PaymentTypeGroupLink.png)

[!include[details](./includes/PaymentTypeGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|paymenttypegrouplink\_id |PK |Clustered, Unique |
|paymenttype\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

