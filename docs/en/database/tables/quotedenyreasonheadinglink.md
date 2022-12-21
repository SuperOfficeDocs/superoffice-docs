---
uid: table-QuoteDenyReasonHeadingLink
title: QuoteDenyReasonHeadingLink table
description: Heading link table for QuoteDenyReason, for MDO headers
so.generated: true
keywords:
  - "database"
  - "QuoteDenyReasonHeadingLink"
so.date: 08.26.2022
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# QuoteDenyReasonHeadingLink Table (511)

Heading link table for QuoteDenyReason, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|quotedenyreasonheadinglink\_id|Primary key|PK| |
|quotedenyreason\_id|Link to QuoteDenyReason list table|FK [QuoteDenyReason](quotedenyreason.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![QuoteDenyReasonHeadingLink table relationship diagram](./media/QuoteDenyReasonHeadingLink.png)

[!include[details](./includes/quotedenyreasonheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|quotedenyreasonheadinglink\_id |PK |Clustered, Unique |
|quotedenyreason\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[QuoteDenyReason](quotedenyreason.md)  |Predefined reasons for quote denial |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

