---
uid: table-reasonstalled
title: reasonstalled table
description: Why was the sale marked as stalled
so.generated: true
keywords:
  - "database"
  - "ReasonStalled"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# reasonstalled Table (154)

reasonstalled MDO list item table.
Why was the sale marked as stalled

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|ReasonStalled\_Id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ReasonStalled table relationship diagram](./media/ReasonStalled.png)

[!include[details](./includes/ReasonStalled.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|ReasonStalled\_Id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

