---
uid: table-prob
title: prob table
description: Prob list table. Probability, used in  sales .
so.generated: true
keywords:
  - "database"
  - "Prob"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# prob Table (82)

prob MDO list item table.
Prob list table. Probability, used in  sales .

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|Prob\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|probability|The numeric probability of the sale|UShort| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![Prob table relationship diagram](./media/Prob.png)

[!include[details](./includes/Prob.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|Prob\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

