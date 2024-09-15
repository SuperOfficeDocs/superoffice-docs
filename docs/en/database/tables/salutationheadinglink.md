---
uid: table-SalutationHeadingLink
title: SalutationHeadingLink table
description: Heading link table for Salutation, for MDO headers
so.generated: true
keywords: database table SalutationHeadingLink
so.topic: reference
so.envir: onsite, online
---

# SalutationHeadingLink Table (221)

Heading link table for Salutation, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|salutationheadinglink\_id|Primary key|PK| |
|salutation\_id|Link to Salutation list table|FK [Salutation](salutation.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SalutationHeadingLink table relationship diagram](./media/SalutationHeadingLink.png)

[!include[details](./includes/salutationheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|salutationheadinglink\_id |PK |Clustered, Unique |
|salutation\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[Salutation](salutation.md)  |Academic title for Person |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

