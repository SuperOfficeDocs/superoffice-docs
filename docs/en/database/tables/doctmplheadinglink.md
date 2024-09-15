---
uid: table-DocTmplHeadingLink
title: DocTmplHeadingLink table
description: Heading link table for DocTmpl, for MDO headers
so.generated: true
keywords: database table DocTmplHeadingLink
so.topic: reference
so.envir: onsite, online
---

# DocTmplHeadingLink Table (132)

Heading link table for DocTmpl, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|doctmplheadinglink\_id|Primary key|PK| |
|doctmpl\_id|Link to DocTmpl list table|FK [DocTmpl](doctmpl.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![DocTmplHeadingLink table relationship diagram](./media/DocTmplHeadingLink.png)

[!include[details](./includes/doctmplheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|doctmplheadinglink\_id |PK |Clustered, Unique |
|doctmpl\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[DocTmpl](doctmpl.md)  |DocTmpl list table. Describes templates available for writing new documents. |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

