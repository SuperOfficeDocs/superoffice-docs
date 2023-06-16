---
uid: table-ContIntHeadingLink
title: ContIntHeadingLink table
description: Heading link table for ContInt, for MDO headers
so.generated: true
keywords: database table ContIntHeadingLink
so.topic: reference
so.envir: onsite, online
---

# ContIntHeadingLink Table (72)

Heading link table for ContInt, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|contintheadinglink\_id|Primary key|PK| |
|contint\_id|Link to ContInt list table|FK [ContInt](contint.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ContIntHeadingLink table relationship diagram](./media/ContIntHeadingLink.png)

[!include[details](./includes/contintheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|contintheadinglink\_id |PK |Clustered, Unique |
|contint\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ContInt](contint.md)  |ContInt list table. List-text of all valid contact interest types. |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

