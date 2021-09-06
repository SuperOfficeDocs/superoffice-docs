---
uid: table-searchcatgrouplink
title: searchcatgrouplink table
description: User group link table for SearchCat, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "SearchCatGroupLink"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# searchcatgrouplink Table (107)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|searchcatgrouplink\_id|Primary key|PK| |
|searchcat\_id|Link to SearchCat list table|FK [searchcat](searchcat.md)| |
|group\_id|Link to Group table|FK [usergroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SearchCatGroupLink table relationship diagram](./media/SearchCatGroupLink.png)

[!include[details](./includes/SearchCatGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|searchcatgrouplink\_id |PK |Clustered, Unique |
|searchcat\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

