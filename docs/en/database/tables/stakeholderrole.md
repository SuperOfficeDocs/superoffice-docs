---
uid: table-StakeholderRole
title: StakeholderRole table
description: Role a stakeholder has in a sale
so.generated: true
keywords: database table StakeholderRole
so.topic: reference
so.envir: onsite, online
---

# StakeholderRole Table (122)

StakeholderRole MDO list item table.
Role a stakeholder has in a sale

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|StakeholderRole\_Id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![StakeholderRole table relationship diagram](./media/StakeholderRole.png)

[!include[details](./includes/stakeholderrole.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|StakeholderRole\_Id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[SaleStakeholder](salestakeholder.md)  |Stakeholders in the sale, very similar to project members |
|[StakeholderRoleGroupLink](stakeholderrolegrouplink.md)  |User group link table for StakeholderRole, for MDO item hiding |
|[StakeholderRoleHeadingLink](stakeholderroleheadinglink.md)  |Heading link table for StakeholderRole, for MDO headers |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

