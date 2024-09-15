---
uid: table-ProjStatusGroupLink
title: ProjStatusGroupLink table
description: User group link table for ProjStatus, for MDO item hiding
so.generated: true
keywords: database table ProjStatusGroupLink
so.topic: reference
so.envir: onsite, online
---

# ProjStatusGroupLink Table (89)

User group link table for ProjStatus, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|projstatusgrouplink\_id|Primary key|PK| |
|projstatus\_id|Link to ProjStatus list table|FK [ProjStatus](projstatus.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProjStatusGroupLink table relationship diagram](./media/ProjStatusGroupLink.png)

[!include[details](./includes/projstatusgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|projstatusgrouplink\_id |PK |Clustered, Unique |
|projstatus\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ProjStatus](projstatus.md)  |ProjStatus list table. Project status |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

