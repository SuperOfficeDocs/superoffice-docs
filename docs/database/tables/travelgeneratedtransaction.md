---
uid: travelgeneratedtransaction
title: travelgeneratedtransaction table
description: Record of all generated replication data files from this database (*.dwn files from mother database to child, *.up from child database to mother)
so.generated: true
keywords:
  - "database"
  - "travelgeneratedtransaction"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# Travelgeneratedtransaction Table (30)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|travelgeneratedtransaction\_id|Primary key|PK| |
|travel\_id|Central=0, Departm.=H01000000-H7F000000, Travel=assoc_id|Id|&#x25CF;|
|tranlogfirst\_id|This up/dwnfile holds transaction from traveltransactionlog_id = this number|FK [traveltransactionlog](traveltransactionlog.md)|&#x25CF;|
|tranloglast\_id|This up/dwnfile holds transaction to traveltransactionlog_id = this number|FK [traveltransactionlog](traveltransactionlog.md)|&#x25CF;|
|recordstatus|gen, sent, ack.|UShort|&#x25CF;|
|transmissionnumber|sequence pr. user|UInt|&#x25CF;|
|transmissiontype|File or direct communication|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![travelgeneratedtransaction table relationship diagram](media\travelgeneratedtransaction.png)

[!include[details](./includes/travelgeneratedtransaction.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|travelgeneratedtransaction\_id |PK |Clustered, Unique |
|travel\_id |Id |Index |
|transmissionnumber, travel\_id |UInt, Id |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

