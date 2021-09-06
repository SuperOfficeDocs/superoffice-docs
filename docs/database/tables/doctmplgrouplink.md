---
uid: table-doctmplgrouplink
title: doctmplgrouplink table
description: User group link table for DocTmpl, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "DocTmplGroupLink"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# doctmplgrouplink Table (131)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|doctmplgrouplink\_id|Primary key|PK| |
|doctmpl\_id|Link to DocTmpl list table|FK [doctmpl](doctmpl.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![DocTmplGroupLink table relationship diagram](./media/DocTmplGroupLink.png)

[!include[details](./includes/DocTmplGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|doctmplgrouplink\_id |PK |Clustered, Unique |
|doctmpl\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

