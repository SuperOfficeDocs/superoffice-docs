---
uid: table-TagsGroupLink
title: TagsGroupLink table
description: User group link table for Tags, for MDO item hiding
so.generated: true
keywords: database table TagsGroupLink
so.topic: reference
so.envir: onsite, online
---

# TagsGroupLink Table (460)

User group link table for Tags, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|tagsgrouplink\_id|Primary key|PK| |
|tags\_id|Link to Tags list table|FK [Tags](tags.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![TagsGroupLink table relationship diagram](./media/TagsGroupLink.png)

[!include[details](./includes/tagsgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|tagsgrouplink\_id |PK |Clustered, Unique |
|tags\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Tags](tags.md)  |MDO List of tags for Service entities |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

