---
uid: table-ProbGroupLink
title: ProbGroupLink table
description: User group link table for Prob, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "ProbGroupLink"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ProbGroupLink Table (83)

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

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|probgrouplink\_id |PK |Clustered, Unique |
|prob\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

