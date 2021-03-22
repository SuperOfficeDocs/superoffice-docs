---
uid: table-currencyheadinglink
title: currencyheadinglink table
description: Heading link table for Currency, for MDO headers
so.generated: true
keywords:
  - "database"
  - "CurrencyHeadingLink"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# currencyheadinglink Table (114)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|currencyheadinglink\_id|Primary key|PK| |
|currency\_id|Link to Currency list table|FK [currency](currency.md)| |
|heading\_id|Link to Heading table|FK [heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![CurrencyHeadingLink table relationship diagram](./media/CurrencyHeadingLink.png)

[!include[details](./includes/CurrencyHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|currencyheadinglink\_id |PK |Clustered, Unique |
|currency\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

