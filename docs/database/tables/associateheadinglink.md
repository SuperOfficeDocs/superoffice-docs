---
uid: table-AssociateHeadingLink
title: AssociateHeadingLink table
description: Heading link table for associate for display only. Supportive table, used for grouping and filtering on lists. 
so.generated: true
keywords:
  - "database"
  - "AssociateHeadingLink"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# AssociateHeadingLink Table (4)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|associateheadinglink\_id|Primary key|PK| |
|associate\_id|Link to Associate list table|FK [associate](associate.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![AssociateHeadingLink table relationship diagram](./media/AssociateHeadingLink.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|associateheadinglink\_id |PK |Clustered, Unique |
|associate\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

