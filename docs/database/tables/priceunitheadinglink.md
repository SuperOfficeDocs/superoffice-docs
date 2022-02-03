---
uid: table-PriceUnitHeadingLink
title: PriceUnitHeadingLink table
description: Heading link table for PriceUnit, for MDO item headings
so.generated: true
keywords:
  - "database"
  - "PriceUnitHeadingLink"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# PriceUnitHeadingLink Table (441)

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

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

