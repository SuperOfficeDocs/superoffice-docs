---
uid: table-producttypeheadinglink
title: producttypeheadinglink table
description: Heading link table for ProductType, for MDO item headings
so.generated: true
keywords:
  - "database"
  - "ProductTypeHeadingLink"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# producttypeheadinglink Table (416)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|producttypeheadinglink\_id|Primary key|PK| |
|producttype\_id|Link to ProductType list table|FK [producttype](producttype.md)| |
|heading\_id|Link to Heading table|FK [heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProductTypeHeadingLink table relationship diagram](./media/ProductTypeHeadingLink.png)

[!include[details](./includes/ProductTypeHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|producttypeheadinglink\_id |PK |Clustered, Unique |
|producttype\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

