---
uid: table-TagsHeadingLink
title: TagsHeadingLink table
description: Heading link table for Source, for MDO headers
so.generated: true
keywords: database table TagsHeadingLink
so.topic: reference
so.envir: onsite, online
---

# TagsHeadingLink Table (461)

Heading link table for Source, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|tagsheadinglink\_id|Primary key|PK| |
|tags\_id|Link to Tags list table|FK [Tags](tags.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![TagsHeadingLink table relationship diagram](./media/TagsHeadingLink.png)

[!include[details](./includes/tagsheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|tagsheadinglink\_id |PK |Clustered, Unique |
|tags\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[Tags](tags.md)  |MDO List of tags for Service entities |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

