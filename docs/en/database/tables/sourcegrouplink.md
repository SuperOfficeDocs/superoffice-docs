---
uid: table-SourceGroupLink
title: SourceGroupLink table
description: User group link table for Source, for MDO item hiding
so.generated: true
keywords: database table SourceGroupLink
so.topic: reference
so.envir: onsite, online
---

# SourceGroupLink Table (101)

User group link table for Source, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|sourcegrouplink\_id|Primary key|PK| |
|source\_id|Link to Source list table|FK [Source](source.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SourceGroupLink table relationship diagram](./media/SourceGroupLink.png)

[!include[details](./includes/sourcegrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|sourcegrouplink\_id |PK |Clustered, Unique |
|source\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Source](source.md)  |Source list table. Source for sale (list) |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

