---
uid: table-saletypeheadinglink
title: saletypeheadinglink table
description: Heading link table for SaleType, for MDO headers
so.generated: true
keywords:
  - "database"
  - "SaleTypeHeadingLink"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# saletypeheadinglink Table (151)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|saletypeheadinglink\_id|Primary key|PK| |
|saletype\_id|Link to SaleType list table|FK [saletype](saletype.md)| |
|heading\_id|Link to Heading table|FK [heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SaleTypeHeadingLink table relationship diagram](./media/SaleTypeHeadingLink.png)

[!include[details](./includes/SaleTypeHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|saletypeheadinglink\_id |PK |Clustered, Unique |
|saletype\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

