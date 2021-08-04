---
uid: table-binaryobjectlink
title: binaryobjectlink table
description: Link table, connects a BinaryObject with one or more owners
so.generated: true
keywords:
  - "database"
  - "BinaryObjectLink"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# binaryobjectlink Table (206)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|BinaryObjectLink\_id|Primary key|PK| |
|binaryObjectId|The binary object we link to|FK [binaryobject](binaryobject.md)| |
|ownerTable|The owner table|TableNumber| |
|ownerRecord|The owner record|RecordId| |
|linkComment|Link comment, optional|String(254)|&#x25CF;|
|linkType|The link type|Enum [bloblinktype](enums/bloblinktype.md)| |
|rank|Link rank, in case there are more of one type to one owner|UShort| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![BinaryObjectLink table relationship diagram](./media/BinaryObjectLink.png)

[!include[details](./includes/BinaryObjectLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|BinaryObjectLink\_id |PK |Clustered, Unique |
|ownerTable, ownerRecord, linkType, rank |TableNumber, RecordId, Enum, UShort |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

