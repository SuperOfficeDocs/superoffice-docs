---
uid: table-salutationheadinglink
title: salutationheadinglink table
description: Heading link table for Salutation, for MDO headers
so.generated: true
keywords:
  - "database"
  - "SalutationHeadingLink"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# salutationheadinglink Table (221)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|salutationheadinglink\_id|Primary key|PK| |
|salutation\_id|Link to Salutation list table|FK [salutation](salutation.md)| |
|heading\_id|Link to Heading table|FK [heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SalutationHeadingLink table relationship diagram](./media/SalutationHeadingLink.png)

[!include[details](./includes/SalutationHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|salutationheadinglink\_id |PK |Clustered, Unique |
|salutation\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

