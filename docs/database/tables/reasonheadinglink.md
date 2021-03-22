---
uid: table-reasonheadinglink
title: reasonheadinglink table
description: Heading link table for Reason, for MDO headers
so.generated: true
keywords:
  - "database"
  - "ReasonHeadingLink"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# reasonheadinglink Table (105)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|reasonheadinglink\_id|Primary key|PK| |
|reason\_id|Link to Reason list table|FK [reason](reason.md)| |
|heading\_id|Link to Heading table|FK [heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ReasonHeadingLink table relationship diagram](./media/ReasonHeadingLink.png)

[!include[details](./includes/ReasonHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|reasonheadinglink\_id |PK |Clustered, Unique |
|reason\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

