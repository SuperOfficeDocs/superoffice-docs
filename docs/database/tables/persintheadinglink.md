---
uid: table-PersIntHeadingLink
title: PersIntHeadingLink table
description: Heading link table for PersInt, for MDO headers
so.generated: true
keywords:
  - "database"
  - "PersIntHeadingLink"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# PersIntHeadingLink Table (75)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|persintheadinglink\_id|Primary key|PK| |
|persint\_id|Link to PersInt list table|FK [PersInt](persint.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PersIntHeadingLink table relationship diagram](./media/PersIntHeadingLink.png)

[!include[details](./includes/persintheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|persintheadinglink\_id |PK |Clustered, Unique |
|persint\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

