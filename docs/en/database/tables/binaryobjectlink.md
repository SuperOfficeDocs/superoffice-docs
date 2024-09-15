---
uid: table-BinaryObjectLink
title: BinaryObjectLink table
description: Link table, connects a BinaryObject with one or more owners
so.generated: true
keywords: database table BinaryObjectLink
so.topic: reference
so.envir: onsite, online
---

# BinaryObjectLink Table (206)

Link table, connects a BinaryObject with one or more owners

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|BinaryObjectLink\_id|Primary key|PK| |
|binaryObjectId|The binary object we link to|FK [BinaryObject](binaryobject.md)| |
|ownerTable|The owner table|TableNumber| |
|ownerRecord|The owner record|RecordId| |
|linkComment|Link comment, optional|String(254)|&#x25CF;|
|linkType|The link type|Enum [BlobLinkType](enums/bloblinktype.md)| |
|rank|Link rank, in case there are more of one type to one owner|UShort| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![BinaryObjectLink table relationship diagram](./media/BinaryObjectLink.png)

[!include[details](./includes/binaryobjectlink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|BinaryObjectLink\_id |PK |Clustered, Unique |
|ownerTable, ownerRecord, linkType, rank |TableNumber, RecordId, Enum, UShort |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[BinaryObject](binaryobject.md)  |Binary objects, i.e., blobs. Used for images, documents, SuperOffice inbox mail  and other large binary items |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

