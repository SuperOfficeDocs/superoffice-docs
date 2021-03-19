---
uid: prioritygrouplink
title: prioritygrouplink table
description: User group link table for Priority, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "prioritygrouplink"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# PriorityGroupLink Table (80)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|prioritygrouplink\_id|Primary key|PK| |
|priority\_id|Link to Priority list table|FK [Priority](Priority.md)| |
|group\_id|Link to Group table|FK [UserGroup](UserGroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PriorityGroupLink table relationship diagram](media\PriorityGroupLink.png)

[!include[details](./includes/PriorityGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|prioritygrouplink\_id |PK |Clustered, Unique |
|priority\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

