---
uid: projtypeheadinglink
title: projtypeheadinglink table
description: Heading link table for ProjType, for MDO headers
so.generated: true
keywords:
  - "database"
  - "projtypeheadinglink"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ProjTypeHeadingLink Table (87)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|projtypeheadinglink\_id|Primary key|PK| |
|projtype\_id|Link to ProjType list table|FK [ProjType](ProjType.md)| |
|heading\_id|Link to Heading table|FK [Heading](Heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProjTypeHeadingLink table relationship diagram](media\ProjTypeHeadingLink.png)

[!include[details](./includes/ProjTypeHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|projtypeheadinglink\_id |PK |Clustered, Unique |
|projtype\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

