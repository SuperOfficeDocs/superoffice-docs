---
uid: table-RejectReason
title: RejectReason table
description: Rejection reason (suggested) for bookings
so.generated: true
keywords:
  - "database"
  - "RejectReason"
so.date: 04.12.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# RejectReason Table (222)

RejectReason MDO list item table.
Rejection reason (suggested) for bookings

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|RejectReason\_Id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |

![RejectReason table relationship diagram](./media/RejectReason.png)

[!include[details](./includes/rejectreason.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|RejectReason\_Id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[RejectReasonGroupLink](rejectreasongrouplink.md)  |User group link table for Comptr, for MDO item hiding |
|[RejectReasonHeadingLink](rejectreasonheadinglink.md)  |Heading link table for RejectReason, for MDO headers |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.
