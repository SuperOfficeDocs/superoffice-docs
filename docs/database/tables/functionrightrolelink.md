---
uid: functionrightrolelink
title: functionrightrolelink table
description: Functional right definition
so.generated: true
keywords:
  - "database"
  - "functionrightrolelink"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# FunctionRightRoleLink Table (194)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|FunctionRightRoleLink\_id|Primary key|PK| |
|roleId|Role id|FK [Role](Role.md)| |
|functionRightId|Functional right id|FK [FunctionRight](FunctionRight.md)| |
|encryptedCheck|Encrypted data, to detect unwanted changes|String(254)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![FunctionRightRoleLink table relationship diagram](media\FunctionRightRoleLink.png)

[!include[details](./includes/FunctionRightRoleLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|FunctionRightRoleLink\_id |PK |Clustered, Unique |
|roleId |FK |Index |
|functionRightId |FK |Index |
|roleId, functionRightId |FK, FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

