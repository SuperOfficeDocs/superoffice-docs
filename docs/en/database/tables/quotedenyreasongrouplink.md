---
uid: table-QuoteDenyReasonGroupLink
title: QuoteDenyReasonGroupLink table
description: User group link table for QuoteDenyReason, for MDO item hiding
so.generated: true
keywords: database table QuoteDenyReasonGroupLink
so.topic: reference
so.envir: onsite, online
---

# QuoteDenyReasonGroupLink Table (529)

User group link table for QuoteDenyReason, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|quotedenyreasongrouplink\_id|Primary key|PK| |
|quotedenyreason\_id|Link to QuoteDenyReason list table|FK [QuoteDenyReason](quotedenyreason.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![QuoteDenyReasonGroupLink table relationship diagram](./media/QuoteDenyReasonGroupLink.png)

[!include[details](./includes/quotedenyreasongrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|quotedenyreasongrouplink\_id |PK |Clustered, Unique |
|quotedenyreason\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[QuoteDenyReason](quotedenyreason.md)  |Predefined reasons for quote denial |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

