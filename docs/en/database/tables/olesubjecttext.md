---
uid: table-OLESubjectText
title: OLESubjectText table
description: Control data table for the OLE DB Provider
so.generated: true
keywords: database table OLESubjectText
so.topic: reference
so.envir: onsite, online
---

# OLESubjectText Table (162)

Control data table for the OLE DB Provider

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|OLESubjectText\_id|Primary key|PK| |
|OLESubject\_id|OLE Subject|FK [OLESubject](olesubject.md)| |
|languageId|LCID (see locale help) of language|Id| |
|name|OLE Subject name|String(79)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![OLESubjectText table relationship diagram](./media/OLESubjectText.png)

[!include[details](./includes/olesubjecttext.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|OLESubjectText\_id |PK |Clustered, Unique |
|OLESubject\_id |FK |Index |
|languageId |Id |Index |
|name |String(79) |Index |
|OLESubject\_id, languageId |FK, Id |Index |

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

