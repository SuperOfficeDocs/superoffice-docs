---
uid: table-tagsheadinglink
title: tagsheadinglink table
description: Heading link table for Source, for MDO headers
so.generated: true
keywords:
  - "database"
  - "TagsHeadingLink"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# tagsheadinglink Table (461)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|tagsheadinglink\_id|Primary key|PK| |
|tags\_id|Link to Tags list table|FK [tags](tags.md)| |
|heading\_id|Link to Heading table|FK [heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![TagsHeadingLink table relationship diagram](./media/TagsHeadingLink.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|tagsheadinglink\_id |PK |Clustered, Unique |
|tags\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

