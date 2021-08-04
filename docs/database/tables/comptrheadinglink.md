---
uid: table-comptrheadinglink
title: comptrheadinglink table
description: Heading link table for Comptr, for MDO headers
so.generated: true
keywords:
  - "database"
  - "ComptrHeadingLink"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# comptrheadinglink Table (111)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|comptrheadinglink\_id|Primary key|PK| |
|comptr\_id|Link to Comptr list table|FK [comptr](comptr.md)| |
|heading\_id|Link to Heading table|FK [heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ComptrHeadingLink table relationship diagram](./media/ComptrHeadingLink.png)

[!include[details](./includes/ComptrHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|comptrheadinglink\_id |PK |Clustered, Unique |
|comptr\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

