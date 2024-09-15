---
uid: table-QuoteDenyReason
title: QuoteDenyReason table
description: Predefined reasons for quote denial
so.generated: true
keywords: database table QuoteDenyReason
so.topic: reference
so.envir: onsite, online
---

# QuoteDenyReason Table (528)

QuoteDenyReason MDO list item table.
Predefined reasons for quote denial

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|quotedenyreason\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![QuoteDenyReason table relationship diagram](./media/QuoteDenyReason.png)

[!include[details](./includes/quotedenyreason.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|quotedenyreason\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[QuoteDenyReasonGroupLink](quotedenyreasongrouplink.md)  |User group link table for QuoteDenyReason, for MDO item hiding |
|[QuoteDenyReasonHeadingLink](quotedenyreasonheadinglink.md)  |Heading link table for QuoteDenyReason, for MDO headers |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

