---
uid: table-SourceHeadingLink
title: SourceHeadingLink table
description: Heading link table for Source, for MDO headers
so.generated: true
keywords: database table SourceHeadingLink
so.topic: reference
so.envir: onsite, online
---

# SourceHeadingLink Table (102)

Heading link table for Source, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|sourceheadinglink\_id|Primary key|PK| |
|source\_id|Link to Source list table|FK [Source](source.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SourceHeadingLink table relationship diagram](./media/SourceHeadingLink.png)

[!include[details](./includes/sourceheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|sourceheadinglink\_id |PK |Clustered, Unique |
|source\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[Source](source.md)  |Source list table. Source for sale (list) |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

