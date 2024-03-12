---
uid: table-TaskMenuHeadingLink
title: TaskMenuHeadingLink table
description: Heading link table for TaskMenu, for MDO headers
so.generated: true
keywords: database table TaskMenuHeadingLink
so.topic: reference
so.envir: onsite, online
---

# TaskMenuHeadingLink Table (468)

Heading link table for TaskMenu, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|taskmenuheadinglink\_id|Primary key|PK| |
|taskMenu\_id|Link to TaskMenu list table|FK [TaskMenu](taskmenu.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![TaskMenuHeadingLink table relationship diagram](./media/TaskMenuHeadingLink.png)

[!include[details](./includes/taskmenuheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|taskmenuheadinglink\_id |PK |Clustered, Unique |
|taskMenu\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[TaskMenu](taskmenu.md)  |List items to merge into menues |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

