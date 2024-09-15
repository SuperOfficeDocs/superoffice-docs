---
uid: table-ExtAppHeadingLink
title: ExtAppHeadingLink table
description: Heading link table for ExtApp, for MDO headers
so.generated: true
keywords: database table ExtAppHeadingLink
so.topic: reference
so.envir: onsite, online
---

# ExtAppHeadingLink Table (135)

Heading link table for ExtApp, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|extappheadinglink\_id|Primary key|PK| |
|extapp\_id|Link to ExtApp list table|FK [ExtApp](extapp.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ExtAppHeadingLink table relationship diagram](./media/ExtAppHeadingLink.png)

[!include[details](./includes/extappheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|extappheadinglink\_id |PK |Clustered, Unique |
|extapp\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ExtApp](extapp.md)  |ExtApp list table. Applications startable from SuperOffice |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

