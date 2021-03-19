---
uid: olesubject
title: olesubject table
description: Control data table for the OLE DB Provider
so.generated: true
keywords:
  - "database"
  - "olesubject"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# OLESubject Table (161)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|OLESubject\_id|Primary key|PK| |
|predefined|1 = predefined subject, do not change|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![OLESubject table relationship diagram](media\OLESubject.png)

[!include[details](./includes/OLESubject.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|OLESubject\_id |PK |Clustered, Unique |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

