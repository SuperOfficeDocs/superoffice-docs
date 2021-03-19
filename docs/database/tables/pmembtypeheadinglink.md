---
uid: pmembtypeheadinglink
title: pmembtypeheadinglink table
description: Heading link table for PMembType, for MDO headers
so.generated: true
keywords:
  - "database"
  - "pmembtypeheadinglink"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# PMembTypeHeadingLink Table (93)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|pmembtypeheadinglink\_id|Primary key|PK| |
|pmembtype\_id|Link to PMembType list table|FK [PMembType](PMembType.md)| |
|heading\_id|Link to Heading table|FK [Heading](Heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PMembTypeHeadingLink table relationship diagram](media\PMembTypeHeadingLink.png)

[!include[details](./includes/PMembTypeHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|pmembtypeheadinglink\_id |PK |Clustered, Unique |
|pmembtype\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

