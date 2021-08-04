---
uid: table-persposheadinglink
title: persposheadinglink table
description: Heading link table for PersPos, for MDO headers
so.generated: true
keywords:
  - "database"
  - "PersPosHeadingLink"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# persposheadinglink Table (78)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|persposheadinglink\_id|Primary key|PK| |
|perspos\_id|Link to PersPos list table|FK [perspos](perspos.md)| |
|heading\_id|Link to Heading table|FK [heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PersPosHeadingLink table relationship diagram](./media/PersPosHeadingLink.png)

[!include[details](./includes/PersPosHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|persposheadinglink\_id |PK |Clustered, Unique |
|perspos\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

