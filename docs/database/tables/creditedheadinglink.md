---
uid: table-creditedheadinglink
title: creditedheadinglink table
description: Heading link table for Credited, for MDO headers
so.generated: true
keywords:
  - "database"
  - "CreditedHeadingLink"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# creditedheadinglink Table (99)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|creditedheadinglink\_id|Primary key|PK| |
|credited\_id|Link to Credited list table|FK [credited](credited.md)| |
|heading\_id|Link to Heading table|FK [heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![CreditedHeadingLink table relationship diagram](./media/CreditedHeadingLink.png)

[!include[details](./includes/CreditedHeadingLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|creditedheadinglink\_id |PK |Clustered, Unique |
|credited\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

