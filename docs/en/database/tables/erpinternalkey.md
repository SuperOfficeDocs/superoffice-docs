---
uid: table-ErpInternalKey
title: ErpInternalKey table
description: The internal (superoffice-facing) key related to a synchronized record
so.generated: true
keywords: database table ErpInternalKey
so.topic: reference
so.envir: onsite, online
---

# ErpInternalKey Table (422)

The internal (superoffice-facing) key related to a synchronized record

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

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ErpExternalKey](erpexternalkey.md)  |The external (ERP-facing) key related to a synchronized record / connection |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

