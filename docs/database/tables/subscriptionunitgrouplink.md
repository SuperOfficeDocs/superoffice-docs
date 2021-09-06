---
uid: table-subscriptionunitgrouplink
title: subscriptionunitgrouplink table
description: User group link table for SubscriptionUnit, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "SubscriptionUnitGroupLink"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# subscriptionunitgrouplink Table (443)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|subscriptionunitgrouplink\_id|Primary key|PK| |
|subscriptionunit\_id|Link to SubscriptionUnit list table|FK [subscriptionunit](subscriptionunit.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SubscriptionUnitGroupLink table relationship diagram](./media/SubscriptionUnitGroupLink.png)

[!include[details](./includes/SubscriptionUnitGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|subscriptionunitgrouplink\_id |PK |Clustered, Unique |
|subscriptionunit\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

