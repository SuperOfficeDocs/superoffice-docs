---
uid: table-QuoteApprReasonHeadingLink
title: QuoteApprReasonHeadingLink table
description: Heading link table for QuoteApprReason, for MDO headers
so.generated: true
keywords: database table QuoteApprReasonHeadingLink
so.topic: reference
so.envir: onsite, online
---

# QuoteApprReasonHeadingLink Table (527)

Heading link table for QuoteApprReason, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|quoteapprreasonheadinglink\_id|Primary key|PK| |
|quoteapprreason\_id|Link to QuoteApprReason list table|FK [QuoteApprReason](quoteapprreason.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![QuoteApprReasonHeadingLink table relationship diagram](./media/QuoteApprReasonHeadingLink.png)

[!include[details](./includes/quoteapprreasonheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|quoteapprreasonheadinglink\_id |PK |Clustered, Unique |
|quoteapprreason\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[QuoteApprReason](quoteapprreason.md)  |Predefined reasons for quote approval |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

