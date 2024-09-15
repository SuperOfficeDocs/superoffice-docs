---
uid: table-AssociateHeadingLink
title: AssociateHeadingLink table
description: Heading link table for associate for display only. Supportive table, used for grouping and filtering on lists. 
so.generated: true
keywords: database table AssociateHeadingLink
so.topic: reference
so.envir: onsite, online
---

# AssociateHeadingLink Table (4)

Heading link table for associate for display only. Supportive table, used for grouping and filtering on lists. 

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|associateheadinglink\_id|Primary key|PK| |
|associate\_id|Link to Associate list table|FK [associate](associate.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![AssociateHeadingLink table relationship diagram](./media/AssociateHeadingLink.png)

[!include[details](./includes/associateheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|associateheadinglink\_id |PK |Clustered, Unique |
|associate\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

