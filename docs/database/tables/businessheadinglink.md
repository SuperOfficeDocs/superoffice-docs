---
uid: table-BusinessHeadingLink
title: BusinessHeadingLink table
description: Heading link table for Business, for MDO headers
so.generated: true
keywords:
  - "database"
  - "BusinessHeadingLink"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# BusinessHeadingLink Table (63)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|businessheadinglink\_id|Primary key|PK| |
|business\_id|Link to Business list table|FK [Business](business.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![BusinessHeadingLink table relationship diagram](./media/BusinessHeadingLink.png)

[!include[details](./includes/businessheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|businessheadinglink\_id |PK |Clustered, Unique |
|business\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

