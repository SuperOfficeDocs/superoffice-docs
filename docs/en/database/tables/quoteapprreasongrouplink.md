---
uid: table-QuoteApprReasonGroupLink
title: QuoteApprReasonGroupLink table
description: User group link table for QuoteApprReason, for MDO item hiding
so.generated: true
keywords: database table QuoteApprReasonGroupLink
so.topic: reference
so.envir: onsite, online
---

# QuoteApprReasonGroupLink Table (526)

User group link table for QuoteApprReason, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|quoteapprreasongrouplink\_id|Primary key|PK| |
|quoteapprreason\_id|Link to QuoteApprReason list table|FK [QuoteApprReason](quoteapprreason.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![QuoteApprReasonGroupLink table relationship diagram](./media/QuoteApprReasonGroupLink.png)

[!include[details](./includes/quoteapprreasongrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|quoteapprreasongrouplink\_id |PK |Clustered, Unique |
|quoteapprreason\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[QuoteApprReason](quoteapprreason.md)  |Predefined reasons for quote approval |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

