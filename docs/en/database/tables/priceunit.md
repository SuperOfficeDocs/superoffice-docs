---
uid: table-PriceUnit
title: PriceUnit table
description: The list of price units, in the internal product register (meter, ton, bushel, microsecond, gradus, τρυβλίον, 五合枡, دونم or whatever)
so.generated: true
keywords: database table PriceUnit
so.topic: reference
so.envir: onsite, online
---

# PriceUnit Table (439)

PriceUnit MDO list item table.
The list of price units, in the internal product register (meter, ton, bushel, microsecond, gradus, τρυβλίον, 五合枡, دونم or whatever)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|priceunit\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PriceUnit table relationship diagram](./media/PriceUnit.png)

[!include[details](./includes/priceunit.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|priceunit\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[PriceUnitGroupLink](priceunitgrouplink.md)  |User group link table for PriceUnit, for MDO item hiding |
|[PriceUnitHeadingLink](priceunitheadinglink.md)  |Heading link table for PriceUnit, for MDO item headings |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

