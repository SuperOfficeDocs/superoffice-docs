---
uid: table-StakeholderRoleHeadingLink
title: StakeholderRoleHeadingLink table
description: Heading link table for StakeholderRole, for MDO headers
so.generated: true
keywords:
  - "database"
  - "StakeholderRoleHeadingLink"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# StakeholderRoleHeadingLink Table (124)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|stakeholderroleheadinglink\_id|Primary key|PK| |
|stakeholderrole\_id|Link to StakeholderRole list table|FK [StakeholderRole](stakeholderrole.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![StakeholderRoleHeadingLink table relationship diagram](./media/StakeholderRoleHeadingLink.png)

[!include[details](./includes/stakeholderroleheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|stakeholderroleheadinglink\_id |PK |Clustered, Unique |
|stakeholderrole\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

