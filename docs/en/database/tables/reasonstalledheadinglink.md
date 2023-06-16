---
uid: table-ReasonStalledHeadingLink
title: ReasonStalledHeadingLink table
description: Heading link table for ReasonStalled, for MDO headers
so.generated: true
keywords: database table ReasonStalledHeadingLink
so.topic: reference
so.envir: onsite, online
---

# ReasonStalledHeadingLink Table (156)

Heading link table for ReasonStalled, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|reasonstalledheadinglink\_id|Primary key|PK| |
|reasonstalled\_id|Link to ReasonStalled list table|FK [ReasonStalled](reasonstalled.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ReasonStalledHeadingLink table relationship diagram](./media/ReasonStalledHeadingLink.png)

[!include[details](./includes/reasonstalledheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|reasonstalledheadinglink\_id |PK |Clustered, Unique |
|reasonstalled\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[ReasonStalled](reasonstalled.md)  |Why was the sale marked as stalled |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

