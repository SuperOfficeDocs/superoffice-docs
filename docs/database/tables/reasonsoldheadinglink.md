---
uid: table-reasonsoldheadinglink
title: reasonsoldheadinglink table
description: Heading link table for ReasonSold, for MDO headers
so.generated: true
keywords:
  - "database"
  - "ReasonSoldHeadingLink"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# reasonsoldheadinglink Table (117)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|reasonsoldheadinglink\_id|Primary key|PK| |
|reasonsold\_id|Link to ReasonSold list table|FK [reasonsold](reasonsold.md)| |
|heading\_id|Link to Heading table|FK [heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ReasonSoldHeadingLink table relationship diagram](./media/ReasonSoldHeadingLink.png)

[!include[details](./includes/ReasonSoldHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|reasonsoldheadinglink\_id |PK |Clustered, Unique |
|reasonsold\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

