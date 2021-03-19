---
uid: producttypegrouplink
title: producttypegrouplink table
description: User group link table for ProductType, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "producttypegrouplink"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ProductTypeGroupLink Table (415)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|producttypegrouplink\_id|Primary key|PK| |
|producttype\_id|Link to ProductType list table|FK [ProductType](ProductType.md)| |
|group\_id|Link to Group table|FK [UserGroup](UserGroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProductTypeGroupLink table relationship diagram](media\ProductTypeGroupLink.png)

[!include[details](./includes/ProductTypeGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|producttypegrouplink\_id |PK |Clustered, Unique |
|producttype\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

