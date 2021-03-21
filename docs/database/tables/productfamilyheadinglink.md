---
uid: table-productfamilyheadinglink
title: productfamilyheadinglink table
description: Heading link table for ProductFamily, for MDO item headings
so.generated: true
keywords:
  - "database"
  - "ProductFamilyHeadingLink"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# productfamilyheadinglink Table (413)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|productfamilyheadinglink\_id|Primary key|PK| |
|productfamily\_id|Link to ProductFamily list table|FK [productfamily](productfamily.md)| |
|heading\_id|Link to Heading table|FK [heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProductFamilyHeadingLink table relationship diagram](./media/ProductFamilyHeadingLink.png)

[!include[details](./includes/ProductFamilyHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|productfamilyheadinglink\_id |PK |Clustered, Unique |
|productfamily\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

