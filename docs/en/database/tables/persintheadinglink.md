---
uid: table-PersIntHeadingLink
title: PersIntHeadingLink table
description: Heading link table for PersInt, for MDO headers
so.generated: true
keywords: database table PersIntHeadingLink
so.topic: reference
so.envir: onsite, online
---

# PersIntHeadingLink Table (75)

Heading link table for PersInt, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|persintheadinglink\_id|Primary key|PK| |
|persint\_id|Link to PersInt list table|FK [PersInt](persint.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PersIntHeadingLink table relationship diagram](./media/PersIntHeadingLink.png)

[!include[details](./includes/persintheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|persintheadinglink\_id |PK |Clustered, Unique |
|persint\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[PersInt](persint.md)  |PersInt list table. List of Person interests. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

