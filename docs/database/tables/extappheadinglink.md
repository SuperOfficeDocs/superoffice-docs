---
uid: extappheadinglink
title: extappheadinglink table
description: Heading link table for ExtApp, for MDO headers
so.generated: true
keywords:
  - "database"
  - "extappheadinglink"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ExtAppHeadingLink Table (135)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|extappheadinglink\_id|Primary key|PK| |
|extapp\_id|Link to ExtApp list table|FK [ExtApp](ExtApp.md)| |
|heading\_id|Link to Heading table|FK [Heading](Heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ExtAppHeadingLink table relationship diagram](media\ExtAppHeadingLink.png)

[!include[details](./includes/ExtAppHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|extappheadinglink\_id |PK |Clustered, Unique |
|extapp\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

