---
uid: table-ImportField
title: ImportField table
description: Import object types - see localetext for names
so.generated: true
keywords: database table ImportField
so.topic: reference
so.envir: onsite, online
---

# ImportField Table (187)

Import object types - see localetext for names

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|ImportField\_id|Primary key|PK| |
|ImportObject\_id|The primary object type for this import field|FK [ImportObject](importobject.md)| |
|dbFieldId|Database field id of target field (implies table)|FieldId| |
|guiCategory|Used for grouping objects in GUI; see LocaleText for name|Id| |
|tag|Name of field, not visible to the user|String(11)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|isBuiltin|1 = This row populated and maintained by SuperOffice|UShort|&#x25CF;|


![ImportField table relationship diagram](./media/ImportField.png)

[!include[details](./includes/importfield.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|ImportField\_id |PK |Clustered, Unique |
|ImportObject\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ImportObject](importobject.md)  |Import object types - see localetext for names. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

