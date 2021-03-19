---
uid: source
title: source table
description: Source list table. Source for sale (list)
so.generated: true
keywords:
  - "database"
  - "source"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# Source Table (100)

Source MDO list item table.
Source list table. Source for sale (list)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|Source\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![Source table relationship diagram](media\Source.png)

[!include[details](./includes/Source.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|Source\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

