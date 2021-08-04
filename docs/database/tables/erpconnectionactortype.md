---
uid: table-erpconnectionactortype
title: erpconnectionactortype table
description: Data about the configuration of one Erp Actor on one ErpConnection
so.generated: true
keywords:
  - "database"
  - "ErpConnectionActorType"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# erpconnectionactortype Table (419)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|erpconnectionactortype\_id|Primary key|PK| |
|ErpConnectionId|The connection this actor is configured for|FK [erpconnection](erpconnection.md)| |
|ActorTypeErp|The actor type (ERP side)|Enum [erpactortype](enums/erpactortype.md)| |
|ActorTypeCrm|The actor type (CRM side)|Enum [crmactortype](enums/crmactortype.md)|&#x25CF;|
|IsActive|Is this mapping/synchronization configuration currently active|Bool| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ErpConnectionActorType table relationship diagram](./media/ErpConnectionActorType.png)

[!include[details](./includes/ErpConnectionActorType.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|erpconnectionactortype\_id |PK |Clustered, Unique |
|ErpConnectionId, ActorTypeErp |FK, Enum |Unique |
|ErpConnectionId, ActorTypeCrm |FK, Enum |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

