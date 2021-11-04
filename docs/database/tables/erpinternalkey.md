---
uid: table-ErpInternalKey
title: ErpInternalKey table
description: The internal (superoffice-facing) key related to a synchronized record
so.generated: true
keywords:
  - "database"
  - "ErpInternalKey"
so.date: 11.04.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ErpInternalKey Table (422)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|erpinternalkey\_id|Primary key|PK| |
|tableId|ID of table this right is valid for|TableNumber| |
|recordId|ID of row this right applies to|RecordId| |
|MostRecentTimestamp|Datetime, transaction number or other identification of the point in time of the most-recently seen actor in the ERP system|String(254)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ErpInternalKey table relationship diagram](./media/ErpInternalKey.png)

[!include[details](./includes/erpinternalkey.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|erpinternalkey\_id |PK |Clustered, Unique |
|recordId, tableId |RecordId, TableNumber |Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

