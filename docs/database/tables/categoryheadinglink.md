---
uid: table-categoryheadinglink
title: categoryheadinglink table
description: Heading link table for Category, for MDO headers
so.generated: true
keywords:
  - "database"
  - "CategoryHeadingLink"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# categoryheadinglink Table (66)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|categoryheadinglink\_id|Primary key|PK| |
|category\_id|Link to Category list table|FK [category](category.md)| |
|heading\_id|Link to Heading table|FK [heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![CategoryHeadingLink table relationship diagram](./media/CategoryHeadingLink.png)

[!include[details](./includes/CategoryHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|categoryheadinglink\_id |PK |Clustered, Unique |
|category\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

