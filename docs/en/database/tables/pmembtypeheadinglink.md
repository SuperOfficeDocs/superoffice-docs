---
uid: table-PMembTypeHeadingLink
title: PMembTypeHeadingLink table
description: Heading link table for PMembType, for MDO headers
so.generated: true
keywords: database table PMembTypeHeadingLink
so.topic: reference
so.envir: onsite, online
---

# PMembTypeHeadingLink Table (93)

Heading link table for PMembType, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|pmembtypeheadinglink\_id|Primary key|PK| |
|pmembtype\_id|Link to PMembType list table|FK [PMembType](pmembtype.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PMembTypeHeadingLink table relationship diagram](./media/PMembTypeHeadingLink.png)

[!include[details](./includes/pmembtypeheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|pmembtypeheadinglink\_id |PK |Clustered, Unique |
|pmembtype\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[PMembType](pmembtype.md)  |PMembType list table. List text of titles (member types) for project members. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

