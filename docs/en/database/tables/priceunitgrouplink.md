---
uid: table-PriceUnitGroupLink
title: PriceUnitGroupLink table
description: User group link table for PriceUnit, for MDO item hiding
so.generated: true
keywords: database table PriceUnitGroupLink
so.topic: reference
so.envir: onsite, online
---

# PriceUnitGroupLink Table (440)

User group link table for PriceUnit, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|priceunitgrouplink\_id|Primary key|PK| |
|priceunit\_id|Link to PriceUnit list table|FK [PriceUnit](priceunit.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PriceUnitGroupLink table relationship diagram](./media/PriceUnitGroupLink.png)

[!include[details](./includes/priceunitgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|priceunitgrouplink\_id |PK |Clustered, Unique |
|priceunit\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[PriceUnit](priceunit.md)  |The list of price units, in the internal product register (meter, ton, bushel, microsecond, gradus, τρυβλίον, 五合枡, دونم or whatever) |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

