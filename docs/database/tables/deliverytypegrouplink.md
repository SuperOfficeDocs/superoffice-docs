---
uid: table-deliverytypegrouplink
title: deliverytypegrouplink table
description: User group link table for DeliveryType, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "DeliveryTypeGroupLink"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# deliverytypegrouplink Table (437)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|deliverytypegrouplink\_id|Primary key|PK| |
|deliverytype\_id|Link to DeliveryType list table|FK [deliverytype](deliverytype.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![DeliveryTypeGroupLink table relationship diagram](./media/DeliveryTypeGroupLink.png)

[!include[details](./includes/DeliveryTypeGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|deliverytypegrouplink\_id |PK |Clustered, Unique |
|deliverytype\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

