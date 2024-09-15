---
uid: table-ProjTypeHeadingLink
title: ProjTypeHeadingLink table
description: Heading link table for ProjType, for MDO headers
so.generated: true
keywords: database table ProjTypeHeadingLink
so.topic: reference
so.envir: onsite, online
---

# ProjTypeHeadingLink Table (87)

Heading link table for ProjType, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|projtypeheadinglink\_id|Primary key|PK| |
|projtype\_id|Link to ProjType list table|FK [ProjType](projtype.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProjTypeHeadingLink table relationship diagram](./media/ProjTypeHeadingLink.png)

[!include[details](./includes/projtypeheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|projtypeheadinglink\_id |PK |Clustered, Unique |
|projtype\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[ProjType](projtype.md)  |ProjType list table. List of valid Project types. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

