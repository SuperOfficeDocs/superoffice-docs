---
uid: usergroup
title: usergroup table
description: Secondary user groups
so.generated: true
keywords:
  - "database"
  - "usergroup"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# UserGroup Table (59)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|UserGroup\_id|Primary key|PK| |
|name|UserGroup name|String(239)| |
|rank|Rank order |UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|type|0 = department, other values = ? (workgroup, role, …)|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![UserGroup table relationship diagram](media\UserGroup.png)

[!include[details](./includes/UserGroup.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|UserGroup\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

