---
uid: table-CategoryHeadingLink
title: CategoryHeadingLink table
description: Heading link table for Category, for MDO headers
so.generated: true
keywords: database table CategoryHeadingLink
so.topic: reference
so.envir: onsite, online
---

# CategoryHeadingLink Table (66)

Heading link table for Category, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|categoryheadinglink\_id|Primary key|PK| |
|category\_id|Link to Category list table|FK [Category](category.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![CategoryHeadingLink table relationship diagram](./media/CategoryHeadingLink.png)

[!include[details](./includes/categoryheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|categoryheadinglink\_id |PK |Clustered, Unique |
|category\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Category](category.md)  |Category list table |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

