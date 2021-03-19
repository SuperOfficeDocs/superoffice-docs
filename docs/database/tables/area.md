---
uid: area
title: area table
description: Definition of an Area (database subset for satellite and travel)
so.generated: true
keywords:
  - "database"
  - "area"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# Area Table (38)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|area\_id|Primary key|PK| |
|name|Area name|String(49)|&#x25CF;|
|parent\_area\_id|Reserved/not implemented: for subareas, travel from satellite, maybe future multi-level satellites|FK [area](area.md)|&#x25CF;|
|allData|if set to 1, means &apos;no filtering&apos;|UShort|&#x25CF;|
|dbType|0 = as in preferences, 1 = Sybase Anywhere, 2 = Ctree; used when generating prototypes|UShort|&#x25CF;|
|filterType|Area filtering algorithm - reserved for future use|UShort|&#x25CF;|
|encryptedComm|Use encryption for this Area?|UShort|&#x25CF;|
|maxDataAge|Max age of data when generating db&apos;s based on this area|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![area table relationship diagram](media\area.png)

[!include[details](./includes/area.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|area\_id |PK |Clustered, Unique |
|parent\_area\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Copy to satellite and travel prototypes.
* Cache table during filtering.

## Security Flags

* No access control via user's Role.

