---
uid: table-reporterlistdef
title: reporterlistdef table
description: Reporter definitions
so.generated: true
keywords:
  - "database"
  - "ReporterListDef"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# reporterlistdef Table (170)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|ReporterListDef\_id|Primary key|PK| |
|oleViewId|OLE View link|FK [oleview](oleview.md)| |
|oleFieldKey|OLE Field link|FK [olefield](olefield.md)| |
|oleFieldName|OLE Field link|FK [olefield](olefield.md)| |
|listSource|Source table name|String(254)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ReporterListDef table relationship diagram](./media/ReporterListDef.png)

[!include[details](./includes/ReporterListDef.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|ReporterListDef\_id |PK |Clustered, Unique |
|oleViewId |FK |Index |
|oleFieldKey |FK |Index |
|oleFieldName |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

