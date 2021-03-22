---
uid: table-contint
title: contint table
description: ContInt list table. List-text of all valid contact interest types.
so.generated: true
keywords:
  - "database"
  - "ContInt"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# contint Table (70)

contint MDO list item table.
ContInt list table. List-text of all valid contact interest types.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|ContInt\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ContInt table relationship diagram](./media/ContInt.png)

[!include[details](./includes/ContInt.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|ContInt\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

