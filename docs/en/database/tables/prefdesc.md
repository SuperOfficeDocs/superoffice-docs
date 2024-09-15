---
uid: table-PrefDesc
title: PrefDesc table
description: Preference description, drives the Preference GUI. Maintenance client - controls all preferences in SuperOffice. You find an overview off all standard preference on http;//techdoc.superoffice.com.  May be used by third-party developers to add system preferences to be updated from SuperOffice Maintenance client, instead of ini-files. 
so.generated: true
keywords: database table PrefDesc
so.topic: reference
so.envir: onsite, online
---

# PrefDesc Table (184)

Preference description, drives the Preference GUI. Maintenance client - controls all preferences in SuperOffice. You find an overview off all standard preference on http;//techdoc.superoffice.com.  May be used by third-party developers to add system preferences to be updated from SuperOffice Maintenance client, instead of ini-files. 

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|PrefDesc\_id|Primary key|PK| |
|prefsection|Preference section name|String(199)| |
|prefkey|Preference key name|String(199)| |
|name|Multi-language name|String(254)|&#x25CF;|
|valueType|1=number, 2=text, 3=bool, 4=list of values; 5=list table ref; 6=contact ID, 7=Person ID, 8=Project ID, 9=Selection ID|Enum [PrefDescValueType](enums/prefdescvaluetype.md)|&#x25CF;|
|maxLevel|Lowest allowed setting level, set by user, but not lower than sysMaxLevel|Enum [PreferenceLevel](enums/preferencelevel.md)|&#x25CF;|
|sysMaxLevel|Lowest allowed setting level, set by SuperOffice|Enum [PreferenceLevel](enums/preferencelevel.md)|&#x25CF;|
|accessFlags|1=wizard mode, 2=level 0, 4=admin gui, 8=crm gui|Enum [PrefDescAccessFlags](enums/prefdescaccessflags.md)|&#x25CF;|
|maxValue|Max value (if type 1); list table ID (if type 5)|Int|&#x25CF;|
|minValue|Min value (if type 1); list extra id (if type 5)|Int|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|description|Description of preference, multi-language parsed|String(2047)|&#x25CF;|
|isBuiltin|1 = This row populated and maintained by SuperOffice|UShort|&#x25CF;|
|requiredLicense|Licenses the user/installation must have if this reference is to be shown. Comma-separated list of owner.module pairs|String(254)|&#x25CF;|
|rank|Rank field for ordering sections, and keys within sections|Int|&#x25CF;|
|subGroup|Keys that share a value (including NULL) in this field are shown together; a visual spacer is shown between groups|String(128)|&#x25CF;|
|minLevel|The minimum (furthest away from User) level this preference can be set for|Int|&#x25CF;|


![PrefDesc table relationship diagram](./media/PrefDesc.png)

[!include[details](./includes/prefdesc.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|PrefDesc\_id |PK |Clustered, Unique |
|prefsection |String(199) |Index |
|prefkey |String(199) |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[PrefDescLine](prefdescline.md)  |Preference description - multiple choice line - drives the Preference GUI. May be used by third-party developers to add system preferences to be updated from SuperOffice Maintenance client, instead of ini-files. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

