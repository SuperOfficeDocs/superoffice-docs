---
uid: table-StakeholderRoleHeadingLink
title: StakeholderRoleHeadingLink table
description: Heading link table for StakeholderRole, for MDO headers
so.generated: true
keywords: database table StakeholderRoleHeadingLink
so.topic: reference
so.envir: onsite, online
---

# StakeholderRoleHeadingLink Table (124)

Heading link table for StakeholderRole, for MDO headers

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

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[StakeholderRole](stakeholderrole.md)  |Role a stakeholder has in a sale |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

