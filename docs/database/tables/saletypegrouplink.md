---
uid: table-saletypegrouplink
title: saletypegrouplink table
description: User group link table for SaleType, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "SaleTypeGroupLink"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# saletypegrouplink Table (150)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|saletypegrouplink\_id|Primary key|PK| |
|saletype\_id|Link to SaleType list table|FK [saletype](saletype.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SaleTypeGroupLink table relationship diagram](./media/SaleTypeGroupLink.png)

[!include[details](./includes/SaleTypeGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|saletypegrouplink\_id |PK |Clustered, Unique |
|saletype\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

