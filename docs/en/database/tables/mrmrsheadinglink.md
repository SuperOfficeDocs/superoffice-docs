---
uid: table-MrMrsHeadingLink
title: MrMrsHeadingLink table
description: Heading link table for MrMrs, for MDO headers
so.generated: true
keywords: database table MrMrsHeadingLink
so.topic: reference
so.envir: onsite, online
---

# MrMrsHeadingLink Table (96)

Heading link table for MrMrs, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|mrmrsheadinglink\_id|Primary key|PK| |
|mrmrs\_id|Link to MrMrs list table|FK [MrMrs](mrmrs.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![MrMrsHeadingLink table relationship diagram](./media/MrMrsHeadingLink.png)

[!include[details](./includes/mrmrsheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|mrmrsheadinglink\_id |PK |Clustered, Unique |
|mrmrs\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[MrMrs](mrmrs.md)  |MrMrs list table. List of salutations. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

