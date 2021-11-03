---
uid: table-ReasonSold
title: ReasonSold table
description: Why was the sale marked as sold (why did we succeed)
so.generated: true
keywords:
  - "database"
  - "ReasonSold"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ReasonSold Table (115)

ReasonSold MDO list item table.
Why was the sale marked as sold (why did we succeed)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|ReasonSold\_Id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ReasonSold table relationship diagram](./media/ReasonSold.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|ReasonSold\_Id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

