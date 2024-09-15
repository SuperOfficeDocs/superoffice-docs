---
uid: table-CreditedGroupLink
title: CreditedGroupLink table
description: User group link table for Credited, for MDO item hiding
so.generated: true
keywords: database table CreditedGroupLink
so.topic: reference
so.envir: onsite, online
---

# CreditedGroupLink Table (98)

User group link table for Credited, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|creditedgrouplink\_id|Primary key|PK| |
|credited\_id|Link to Credited list table|FK [Credited](credited.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![CreditedGroupLink table relationship diagram](./media/CreditedGroupLink.png)

[!include[details](./includes/creditedgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|creditedgrouplink\_id |PK |Clustered, Unique |
|credited\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Credited](credited.md)  |Credited list table. List of who is to be credited for the sale. |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

