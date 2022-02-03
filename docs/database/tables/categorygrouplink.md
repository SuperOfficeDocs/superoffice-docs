---
uid: table-CategoryGroupLink
title: CategoryGroupLink table
description: User group link table for Category, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "CategoryGroupLink"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# CategoryGroupLink Table (65)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|categorygrouplink\_id|Primary key|PK| |
|category\_id|Link to Category list table|FK [Category](category.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![CategoryGroupLink table relationship diagram](./media/CategoryGroupLink.png)

[!include[details](./includes/categorygrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|categorygrouplink\_id |PK |Clustered, Unique |
|category\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

