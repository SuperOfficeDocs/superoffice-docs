---
uid: table-PriceUnitHeadingLink
title: PriceUnitHeadingLink table
description: Heading link table for PriceUnit, for MDO item headings
so.generated: true
keywords: database table PriceUnitHeadingLink
so.topic: reference
so.envir: onsite, online
---

# PriceUnitHeadingLink Table (441)

Heading link table for PriceUnit, for MDO item headings

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|priceunitheadinglink\_id|Primary key|PK| |
|priceunit\_id|Link to PriceUnit list table|FK [PriceUnit](priceunit.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PriceUnitHeadingLink table relationship diagram](./media/PriceUnitHeadingLink.png)

[!include[details](./includes/priceunitheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|priceunitheadinglink\_id |PK |Clustered, Unique |
|priceunit\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[PriceUnit](priceunit.md)  |The list of price units, in the internal product register (meter, ton, bushel, microsecond, gradus, τρυβλίον, 五合枡, دونم or whatever) |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

