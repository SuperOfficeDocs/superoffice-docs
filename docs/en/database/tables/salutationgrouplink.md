---
uid: table-SalutationGroupLink
title: SalutationGroupLink table
description: User group link table for Salutation, for MDO item hiding
so.generated: true
keywords: database table SalutationGroupLink
so.topic: reference
so.envir: onsite, online
---

# SalutationGroupLink Table (220)

User group link table for Salutation, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|salutationgrouplink\_id|Primary key|PK| |
|salutation\_id|Link to Salutation list table|FK [Salutation](salutation.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SalutationGroupLink table relationship diagram](./media/SalutationGroupLink.png)

[!include[details](./includes/salutationgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|salutationgrouplink\_id |PK |Clustered, Unique |
|salutation\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Salutation](salutation.md)  |Academic title for Person |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

