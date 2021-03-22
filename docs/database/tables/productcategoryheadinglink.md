---
uid: table-productcategoryheadinglink
title: productcategoryheadinglink table
description: Heading link table for ProductCategory, for MDO item headings
so.generated: true
keywords:
  - "database"
  - "ProductCategoryHeadingLink"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# productcategoryheadinglink Table (410)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|productcategoryheadinglink\_id|Primary key|PK| |
|productcategory\_id|Link to ProductCategory list table|FK [productcategory](productcategory.md)| |
|heading\_id|Link to Heading table|FK [heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProductCategoryHeadingLink table relationship diagram](./media/ProductCategoryHeadingLink.png)

[!include[details](./includes/ProductCategoryHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|productcategoryheadinglink\_id |PK |Clustered, Unique |
|productcategory\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

