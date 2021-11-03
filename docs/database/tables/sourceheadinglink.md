---
uid: table-SourceHeadingLink
title: SourceHeadingLink table
description: Heading link table for Source, for MDO headers
so.generated: true
keywords:
  - "database"
  - "SourceHeadingLink"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# SourceHeadingLink Table (102)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|sourceheadinglink\_id|Primary key|PK| |
|source\_id|Link to Source list table|FK [Source](source.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SourceHeadingLink table relationship diagram](./media/SourceHeadingLink.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|sourceheadinglink\_id |PK |Clustered, Unique |
|source\_id |FK |Index |
|heading\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

