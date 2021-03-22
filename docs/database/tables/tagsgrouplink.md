---
uid: table-tagsgrouplink
title: tagsgrouplink table
description: User group link table for Tags, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "TagsGroupLink"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# tagsgrouplink Table (460)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|tagsgrouplink\_id|Primary key|PK| |
|tags\_id|Link to Tags list table|FK [tags](tags.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![TagsGroupLink table relationship diagram](./media/TagsGroupLink.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|tagsgrouplink\_id |PK |Clustered, Unique |
|tags\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

