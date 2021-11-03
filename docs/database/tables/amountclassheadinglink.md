---
uid: table-AmountClassHeadingLink
title: AmountClassHeadingLink table
description: Heading link table for AmountClass, for MDO headers
so.generated: true
keywords:
  - "database"
  - "AmountClassHeadingLink"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# AmountClassHeadingLink Table (227)

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

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|amountclassheadinglink\_id |PK |Clustered, Unique |
|amountclass\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

