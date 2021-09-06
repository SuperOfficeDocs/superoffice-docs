---
uid: table-priceunitgrouplink
title: priceunitgrouplink table
description: User group link table for PriceUnit, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "PriceUnitGroupLink"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# priceunitgrouplink Table (440)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|priceunitgrouplink\_id|Primary key|PK| |
|priceunit\_id|Link to PriceUnit list table|FK [priceunit](priceunit.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PriceUnitGroupLink table relationship diagram](./media/PriceUnitGroupLink.png)

[!include[details](./includes/PriceUnitGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|priceunitgrouplink\_id |PK |Clustered, Unique |
|priceunit\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

