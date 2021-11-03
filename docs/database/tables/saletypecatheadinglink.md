---
uid: table-SaleTypeCatHeadingLink
title: SaleTypeCatHeadingLink table
description: Heading link table for SaleTypeCat, for MDO headers
so.generated: true
keywords:
  - "database"
  - "SaleTypeCatHeadingLink"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# SaleTypeCatHeadingLink Table (120)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|saletypecatheadinglink\_id|Primary key|PK| |
|saletypecat\_id|Link to SaleTypeCat list table|FK [SaleTypeCat](saletypecat.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SaleTypeCatHeadingLink table relationship diagram](./media/SaleTypeCatHeadingLink.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|saletypecatheadinglink\_id |PK |Clustered, Unique |
|saletypecat\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

