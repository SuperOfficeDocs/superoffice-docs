---
uid: udeffieldgl
title: udeffieldgl table
description: User group link table for UDefField, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "udeffieldgl"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# UDefFieldGL Table (147)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|UDefFieldGL\_Id|Primary key|PK| |
|UDefFieldId|Link to field|FK [UDefField](UDefField.md)| |
|fieldLineNo|Line number in display, 1, 2, 3…|UShort| |
|group\_id|Link to Group table|FK [UserGroup](UserGroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![UDefFieldGL table relationship diagram](media\UDefFieldGL.png)

[!include[details](./includes/UDefFieldGL.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|UDefFieldGL\_Id |PK |Clustered, Unique |
|UDefFieldId |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

