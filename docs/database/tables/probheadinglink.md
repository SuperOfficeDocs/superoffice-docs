---
uid: probheadinglink
title: probheadinglink table
description: Heading link table for Prob, for MDO headers
so.generated: true
keywords:
  - "database"
  - "probheadinglink"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ProbHeadingLink Table (84)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|probheadinglink\_id|Primary key|PK| |
|prob\_id|Link to Prob list table|FK [Prob](Prob.md)| |
|heading\_id|Link to Heading table|FK [Heading](Heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProbHeadingLink table relationship diagram](media\ProbHeadingLink.png)

[!include[details](./includes/ProbHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|probheadinglink\_id |PK |Clustered, Unique |
|prob\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

