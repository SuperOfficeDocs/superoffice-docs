---
uid: table-ImportDefault
title: ImportDefault table
description: Defaults for import fields/objects
so.generated: true
keywords: database table ImportDefault
so.topic: reference
so.envir: onsite, online
---

# ImportDefault Table (189)

Defaults for import fields/objects

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|ImportDefault\_id|Primary key|PK| |
|ImportObject\_id|The object this default applies to|FK [ImportObject](importobject.md)| |
|dbFieldId|The database field (within that object, presumably!) this default applies to|FieldId| |
|intValue|Integer default value|UInt|&#x25CF;|
|strValue|String value|String(254)|&#x25CF;|
|isSearchField|If 1, the given db field is part of the search criteria for the given object|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|isBuiltin|1 = This row populated and maintained by SuperOffice|UShort|&#x25CF;|


![ImportDefault table relationship diagram](./media/ImportDefault.png)

[!include[details](./includes/importdefault.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|ImportDefault\_id |PK |Clustered, Unique |
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

