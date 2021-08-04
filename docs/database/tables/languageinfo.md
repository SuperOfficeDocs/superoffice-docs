---
uid: table-languageinfo
title: languageinfo table
description: Information about languages, from ISO standards and related information
so.generated: true
keywords:
  - "database"
  - "LanguageInfo"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# languageinfo Table (210)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|LanguageInfo\_id|Primary key|PK| |
|defaultLcid|Language/culture id as a numeric .NET code|Id| |
|abbrev3|ISO 3-letter abbreviation|String(3)| |
|abbrev2|ISO 2-letter abbreviation|String(2)| |
|englishName|English name of this language (Norwegian)|String(254)| |
|nativeName|The native name of this language (Norsk Bokmål)|String(254)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|isBuiltIn|Has this row been inserted by SuperOffice priming data|UShort| |


![LanguageInfo table relationship diagram](./media/LanguageInfo.png)

[!include[details](./includes/LanguageInfo.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|LanguageInfo\_id |PK |Clustered, Unique |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

