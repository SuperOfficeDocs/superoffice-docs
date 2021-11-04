---
uid: table-Currency
title: Currency table
description: Currency list table
so.generated: true
keywords:
  - "database"
  - "Currency"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# Currency Table (112)

Currency MDO list item table.
Currency list table

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|Currency\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|rate|Exchange rate|Double| |
|units|Exchange unit scale (0.01, 0.1, 1, 10, 100 etc)|Double| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|isoCode|ISO currency code, see http://www.xe.com/iso4217.php|String(9)|&#x25CF;|


![Currency table relationship diagram](./media/Currency.png)

[!include[details](./includes/currency.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|Currency\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

