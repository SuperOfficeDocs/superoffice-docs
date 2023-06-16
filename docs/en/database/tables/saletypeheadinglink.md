---
uid: table-SaleTypeHeadingLink
title: SaleTypeHeadingLink table
description: Heading link table for SaleType, for MDO headers
so.generated: true
keywords: database table SaleTypeHeadingLink
so.topic: reference
so.envir: onsite, online
---

# SaleTypeHeadingLink Table (151)

Heading link table for SaleType, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|saletypeheadinglink\_id|Primary key|PK| |
|saletype\_id|Link to SaleType list table|FK [SaleType](saletype.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SaleTypeHeadingLink table relationship diagram](./media/SaleTypeHeadingLink.png)

[!include[details](./includes/saletypeheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|saletypeheadinglink\_id |PK |Clustered, Unique |
|saletype\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[SaleType](saletype.md)  |Type of sale - large solution, incremental, whatever fits the organization |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

