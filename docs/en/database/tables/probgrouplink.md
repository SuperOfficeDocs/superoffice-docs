---
uid: table-ProbGroupLink
title: ProbGroupLink table
description: User group link table for Prob, for MDO item hiding
so.generated: true
keywords: database table ProbGroupLink
so.topic: reference
so.envir: onsite, online
---

# ProbGroupLink Table (83)

User group link table for Prob, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|probgrouplink\_id|Primary key|PK| |
|prob\_id|Link to Prob list table|FK [Prob](prob.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProbGroupLink table relationship diagram](./media/ProbGroupLink.png)

[!include[details](./includes/probgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|probgrouplink\_id |PK |Clustered, Unique |
|prob\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Prob](prob.md)  |Prob list table. Probability, used in  sales . |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

