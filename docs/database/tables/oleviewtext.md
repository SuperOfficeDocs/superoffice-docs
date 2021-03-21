---
uid: table-oleviewtext
title: oleviewtext table
description: Control data table for the OLE DB Provider
so.generated: true
keywords:
  - "database"
  - "OLEViewText"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# oleviewtext Table (164)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|OLEViewText\_id|Primary key|PK| |
|OLEView\_id|OLE View|FK [olesubject](olesubject.md)| |
|languageId|LCID (see locale help) of language|Id| |
|name|OLE View name|String(29)| |
|description|View name as shown in Reporter studio.|String(99)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![OLEViewText table relationship diagram](./media/OLEViewText.png)

[!include[details](./includes/OLEViewText.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|OLEViewText\_id |PK |Clustered, Unique |
|OLEView\_id |FK |Index |
|languageId |Id |Index |
|name |String(29) |Index |
|OLEView\_id, languageId |FK, Id |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

