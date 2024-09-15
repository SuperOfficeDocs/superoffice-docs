---
uid: table-PrefDescLine
title: PrefDescLine table
description: Preference description - multiple choice line - drives the Preference GUI. May be used by third-party developers to add system preferences to be updated from SuperOffice Maintenance client, instead of ini-files.
so.generated: true
keywords: database table PrefDescLine
so.topic: reference
so.envir: onsite, online
---

# PrefDescLine Table (185)

Preference description - multiple choice line - drives the Preference GUI. May be used by third-party developers to add system preferences to be updated from SuperOffice Maintenance client, instead of ini-files.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|PrefDescLine\_id|Primary key|PK| |
|PrefDesc\_id|Preference description (parent)|FK [PrefDesc](prefdesc.md)| |
|prefValue|Possible value|String(99)| |
|prefShowValue|Descriptive value, multilang-parsed, to put in list|String(254)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|description|Description of preference value, multi-language parsed|String(2047)|&#x25CF;|
|isBuiltin|1 = This row populated and maintained by SuperOffice|UShort|&#x25CF;|


![PrefDescLine table relationship diagram](./media/PrefDescLine.png)

[!include[details](./includes/prefdescline.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|PrefDescLine\_id |PK |Clustered, Unique |
|PrefDesc\_id |FK |Index |
|prefValue |String(99) |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[PrefDesc](prefdesc.md)  |Preference description, drives the Preference GUI. Maintenance client - controls all preferences in SuperOffice. You find an overview off all standard preference on http://techdoc.superoffice.com.  May be used by third-party developers to add system preferences to be updated from SuperOffice Maintenance client, instead of ini-files.  |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

