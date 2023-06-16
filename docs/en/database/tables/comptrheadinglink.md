---
uid: table-ComptrHeadingLink
title: ComptrHeadingLink table
description: Heading link table for Comptr, for MDO headers
so.generated: true
keywords: database table ComptrHeadingLink
so.topic: reference
so.envir: onsite, online
---

# ComptrHeadingLink Table (111)

Heading link table for Comptr, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|comptrheadinglink\_id|Primary key|PK| |
|comptr\_id|Link to Comptr list table|FK [Comptr](comptr.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ComptrHeadingLink table relationship diagram](./media/ComptrHeadingLink.png)

[!include[details](./includes/comptrheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|comptrheadinglink\_id |PK |Clustered, Unique |
|comptr\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Comptr](comptr.md)  |Comptr list table. List of all possible competitors (sale). |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

