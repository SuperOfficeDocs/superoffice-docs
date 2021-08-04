---
uid: table-reasonstalledheadinglink
title: reasonstalledheadinglink table
description: Heading link table for ReasonStalled, for MDO headers
so.generated: true
keywords:
  - "database"
  - "ReasonStalledHeadingLink"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# reasonstalledheadinglink Table (156)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|reasonstalledheadinglink\_id|Primary key|PK| |
|reasonstalled\_id|Link to ReasonStalled list table|FK [reasonstalled](reasonstalled.md)| |
|heading\_id|Link to Heading table|FK [heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ReasonStalledHeadingLink table relationship diagram](./media/ReasonStalledHeadingLink.png)

[!include[details](./includes/ReasonStalledHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|reasonstalledheadinglink\_id |PK |Clustered, Unique |
|reasonstalled\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

