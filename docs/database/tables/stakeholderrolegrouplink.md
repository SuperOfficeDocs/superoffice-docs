---
uid: table-stakeholderrolegrouplink
title: stakeholderrolegrouplink table
description: User group link table for StakeholderRole, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "StakeholderRoleGroupLink"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# stakeholderrolegrouplink Table (123)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|stakeholderrolegrouplink\_id|Primary key|PK| |
|stakeholderrole\_id|Link to StakeholderRole list table|FK [stakeholderrole](stakeholderrole.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![StakeholderRoleGroupLink table relationship diagram](./media/StakeholderRoleGroupLink.png)

[!include[details](./includes/StakeholderRoleGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|stakeholderrolegrouplink\_id |PK |Clustered, Unique |
|stakeholderrole\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

