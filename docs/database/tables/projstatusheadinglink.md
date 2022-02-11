---
uid: table-ProjStatusHeadingLink
title: ProjStatusHeadingLink table
description: Heading link table for ProjStatus, for MDO headers
so.generated: true
keywords:
  - "database"
  - "ProjStatusHeadingLink"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ProjStatusHeadingLink Table (90)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|projstatusheadinglink\_id|Primary key|PK| |
|projstatus\_id|Link to ProjStatus list table|FK [ProjStatus](projstatus.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProjStatusHeadingLink table relationship diagram](./media/ProjStatusHeadingLink.png)

[!include[details](./includes/projstatusheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|projstatusheadinglink\_id |PK |Clustered, Unique |
|projstatus\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

