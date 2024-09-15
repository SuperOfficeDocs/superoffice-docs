---
uid: table-SearchCatGroupLink
title: SearchCatGroupLink table
description: User group link table for SearchCat, for MDO item hiding
so.generated: true
keywords: database table SearchCatGroupLink
so.topic: reference
so.envir: onsite, online
---

# SearchCatGroupLink Table (107)

User group link table for SearchCat, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|searchcatgrouplink\_id|Primary key|PK| |
|searchcat\_id|Link to SearchCat list table|FK [SearchCat](searchcat.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SearchCatGroupLink table relationship diagram](./media/SearchCatGroupLink.png)

[!include[details](./includes/searchcatgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|searchcatgrouplink\_id |PK |Clustered, Unique |
|searchcat\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[SearchCat](searchcat.md)  |SearchCat list table |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

