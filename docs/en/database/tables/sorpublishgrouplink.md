---
uid: table-SORPublishGroupLink
title: SORPublishGroupLink table
description: Link table used for filtering reports by user group
so.generated: true
keywords: database table SORPublishGroupLink
so.topic: reference
so.envir: onsite, online
---

# SORPublishGroupLink Table (25)

Link table used for filtering reports by user group

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|SORPublishGroupLink\_id|Primary key|PK| |
|SORPublishId|Report to link to a group|FK [SORPublish](sorpublish.md)|&#x25CF;|
|UserGroupId|Group that should be able to see this report|FK [UserGroup](usergroup.md)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SORPublishGroupLink table relationship diagram](./media/SORPublishGroupLink.png)

[!include[details](./includes/sorpublishgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|SORPublishGroupLink\_id |PK |Clustered, Unique |
|SORPublishId |FK |Index |
|UserGroupId |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[SORPublish](sorpublish.md)  |SuperOffice reporter data |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

