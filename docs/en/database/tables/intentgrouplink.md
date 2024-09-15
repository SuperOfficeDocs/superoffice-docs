---
uid: table-IntentGroupLink
title: IntentGroupLink table
description: User group link table for Intent, for MDO item hiding
so.generated: true
keywords: database table IntentGroupLink
so.topic: reference
so.envir: onsite, online
---

# IntentGroupLink Table (217)

User group link table for Intent, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|intentgrouplink\_id|Primary key|PK| |
|intent\_id|Link to Intent list table|FK [Intent](intent.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![IntentGroupLink table relationship diagram](./media/IntentGroupLink.png)

[!include[details](./includes/intentgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|intentgrouplink\_id |PK |Clustered, Unique |
|intent\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Intent](intent.md)  |Intent list for SAINT. More information regarding SuperOffice Sales Intelligence on http://techdoc.superoffice.com  |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

