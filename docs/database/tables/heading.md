---
uid: heading
title: heading table
description: Heading items for all MDO lists, lists that are grouped and filtered.
so.generated: true
keywords:
  - "database"
  - "heading"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# Heading Table (58)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|heading\_id|Primary key|PK| |
|name|The visible heading|String(239)| |
|rank|Rank order |UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is deleted and should not be shown in lists|UShort|&#x25CF;|
|listTableId|Which List is this heading connected to? (table ID)|TableNumber| |
|extraId|Extra ID for refining the list id|Id|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![Heading table relationship diagram](media\Heading.png)

[!include[details](./includes/Heading.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|heading\_id |PK |Clustered, Unique |
|name |String(239) |Index |
|listTableId |TableNumber |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

