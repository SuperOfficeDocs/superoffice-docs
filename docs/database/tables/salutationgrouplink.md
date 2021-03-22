---
uid: table-salutationgrouplink
title: salutationgrouplink table
description: User group link table for Salutation, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "SalutationGroupLink"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# salutationgrouplink Table (220)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|salutationgrouplink\_id|Primary key|PK| |
|salutation\_id|Link to Salutation list table|FK [salutation](salutation.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SalutationGroupLink table relationship diagram](./media/SalutationGroupLink.png)

[!include[details](./includes/SalutationGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|salutationgrouplink\_id |PK |Clustered, Unique |
|salutation\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

