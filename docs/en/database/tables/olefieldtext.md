---
uid: table-OLEFieldText
title: OLEFieldText table
description: Control data table for the OLE DB Provider
so.generated: true
keywords: database table OLEFieldText
so.topic: reference
so.envir: onsite, online
---

# OLEFieldText Table (166)

Control data table for the OLE DB Provider

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|OLEFieldText\_id|Primary key|PK| |
|OLEField\_id|OLE View|FK [OLESubject](olesubject.md)| |
|languageId|LCID (see locale help) of language|Id| |
|name|OLE View name|String(29)| |
|description|Field name as shown in reporter studio|String(99)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![OLEFieldText table relationship diagram](./media/OLEFieldText.png)

[!include[details](./includes/olefieldtext.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|OLEFieldText\_id |PK |Clustered, Unique |
|OLEField\_id |FK |Index |
|languageId |Id |Index |
|name |String(29) |Index |
|OLEField\_id, languageId |FK, Id |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[OLESubject](olesubject.md)  |Control data table for the OLE DB Provider |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

