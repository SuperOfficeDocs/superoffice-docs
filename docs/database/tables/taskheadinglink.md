---
uid: table-TaskHeadingLink
title: TaskHeadingLink table
description: Heading link table for Task, for MDO headers
so.generated: true
keywords:
  - "database"
  - "TaskHeadingLink"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# TaskHeadingLink Table (69)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|taskheadinglink\_id|Primary key|PK| |
|task\_id|Link to Task list table|FK [Task](task.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![TaskHeadingLink table relationship diagram](./media/TaskHeadingLink.png)

[!include[details](./includes/taskheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|taskheadinglink\_id |PK |Clustered, Unique |
|task\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

