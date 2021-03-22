---
uid: table-saletypecatheadinglink
title: saletypecatheadinglink table
description: Heading link table for SaleTypeCat, for MDO headers
so.generated: true
keywords:
  - "database"
  - "SaleTypeCatHeadingLink"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# saletypecatheadinglink Table (120)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|saletypecatheadinglink\_id|Primary key|PK| |
|saletypecat\_id|Link to SaleTypeCat list table|FK [saletypecat](saletypecat.md)| |
|heading\_id|Link to Heading table|FK [heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SaleTypeCatHeadingLink table relationship diagram](./media/SaleTypeCatHeadingLink.png)

[!include[details](./includes/SaleTypeCatHeadingLink.md)]

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

