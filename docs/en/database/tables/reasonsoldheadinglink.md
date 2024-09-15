---
uid: table-ReasonSoldHeadingLink
title: ReasonSoldHeadingLink table
description: Heading link table for ReasonSold, for MDO headers
so.generated: true
keywords: database table ReasonSoldHeadingLink
so.topic: reference
so.envir: onsite, online
---

# ReasonSoldHeadingLink Table (117)

Heading link table for ReasonSold, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|reasonsoldheadinglink\_id|Primary key|PK| |
|reasonsold\_id|Link to ReasonSold list table|FK [ReasonSold](reasonsold.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ReasonSoldHeadingLink table relationship diagram](./media/ReasonSoldHeadingLink.png)

[!include[details](./includes/reasonsoldheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|reasonsoldheadinglink\_id |PK |Clustered, Unique |
|reasonsold\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[ReasonSold](reasonsold.md)  |Why was the sale marked as sold (why did we succeed) |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

