---
uid: table-RejectReasonGroupLink
title: RejectReasonGroupLink table
description: User group link table for Comptr, for MDO item hiding
so.generated: true
keywords: database table RejectReasonGroupLink
so.topic: reference
so.envir: onsite, online
---

# RejectReasonGroupLink Table (223)

User group link table for Comptr, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|rejectreasongrouplink\_id|Primary key|PK| |
|rejectreason\_id|Link to RejectReason list table|FK [RejectReason](rejectreason.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![RejectReasonGroupLink table relationship diagram](./media/RejectReasonGroupLink.png)

[!include[details](./includes/rejectreasongrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|rejectreasongrouplink\_id |PK |Clustered, Unique |
|rejectreason\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[RejectReason](rejectreason.md)  |Rejection reason (suggested) for bookings |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

