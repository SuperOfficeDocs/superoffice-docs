---
uid: table-RejectReasonHeadingLink
title: RejectReasonHeadingLink table
description: Heading link table for RejectReason, for MDO headers
so.generated: true
keywords: database table RejectReasonHeadingLink
so.topic: reference
so.envir: onsite, online
---

# RejectReasonHeadingLink Table (224)

Heading link table for RejectReason, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|rejectreasonheadinglink\_id|Primary key|PK| |
|rejectreason\_id|Link to RejectReason list table|FK [RejectReason](rejectreason.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![RejectReasonHeadingLink table relationship diagram](./media/RejectReasonHeadingLink.png)

[!include[details](./includes/rejectreasonheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|rejectreasonheadinglink\_id |PK |Clustered, Unique |
|rejectreason\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[RejectReason](rejectreason.md)  |Rejection reason (suggested) for bookings |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

