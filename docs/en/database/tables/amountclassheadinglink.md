---
uid: table-AmountClassHeadingLink
title: AmountClassHeadingLink table
description: Heading link table for AmountClass, for MDO headers
so.generated: true
keywords: database table AmountClassHeadingLink
so.topic: reference
so.envir: onsite, online
---

# AmountClassHeadingLink Table (227)

Heading link table for AmountClass, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|amountclassheadinglink\_id|Primary key|PK| |
|amountclass\_id|Link to AmountClass list table|FK [AmountClass](amountclass.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![AmountClassHeadingLink table relationship diagram](./media/AmountClassHeadingLink.png)

[!include[details](./includes/amountclassheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|amountclassheadinglink\_id |PK |Clustered, Unique |
|amountclass\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[AmountClass](amountclass.md)  |Amount Class list for SuperOffice Sales Intelligence (Saint) - used to group sales by amounts, into bins (low --&gt; high) called amount classes. More information regarding SuperOffice Sales Intelligence on http://techdoc.superoffice.com  |
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

