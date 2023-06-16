---
uid: table-TaskHeadingLink
title: TaskHeadingLink table
description: Heading link table for Task, for MDO headers
so.generated: true
keywords: database table TaskHeadingLink
so.topic: reference
so.envir: onsite, online
---

# TaskHeadingLink Table (69)

Heading link table for Task, for MDO headers

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

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[Task](task.md)  |Task list table, activity types, like Phone, Meeting |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

