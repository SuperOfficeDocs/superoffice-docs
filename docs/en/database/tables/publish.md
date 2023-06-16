---
uid: table-Publish
title: Publish table
description: Publishing system for external users
so.generated: true
keywords: database table Publish
so.topic: reference
so.envir: onsite, online
---

# Publish Table (200)

Publishing system for external users

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|Publish\_id|Primary key|PK| |
|tableNumber|Table number this record refers to|TableNumber| |
|recordId|Record number that has been published|RecordId|&#x25CF;|
|publishType|Type of publishing action, 0 = Unknown, 1 = to external persons|Enum [PublishType](enums/publishtype.md)|&#x25CF;|
|publishFrom|Publication valid from (inclusive)|DateTime|&#x25CF;|
|publishTo|Publication valid to (inclusive)|DateTime|&#x25CF;|
|eventDate|The date an event actually happens; you may want to have some special processing around that date|DateTime|&#x25CF;|
|encryptedCheck|Encrypted data, to detect unwanted changes|String(254)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![Publish table relationship diagram](./media/Publish.png)

[!include[details](./includes/publish.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|Publish\_id |PK |Clustered, Unique |
|publishType |Enum |Index |
|tableNumber, recordId, publishType |TableNumber, RecordId, Enum |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

