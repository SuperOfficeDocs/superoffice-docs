---
uid: consentperson
title: consentperson table
description: Link table that defines who has which consents
so.generated: true
keywords:
  - "database"
  - "consentperson"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# ConsentPerson Table (466)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|consentperson\_id|Primary key|PK| |
|person\_id|Person who gave consent|FK [person](person.md)|&#x25CF;|
|consentPurpose\_id|Legal base|FK [ConsentPurpose](ConsentPurpose.md)|&#x25CF;|
|legalBase\_id|Legal base|FK [LegalBase](LegalBase.md)|&#x25CF;|
|consentSource\_id|Consent source|FK [ConsentSource](ConsentSource.md)|&#x25CF;|
|comment|A comment describing why this GDPR change was made|String(255)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ConsentPerson table relationship diagram](media\ConsentPerson.png)

[!include[details](./includes/ConsentPerson.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|consentperson\_id |PK |Clustered, Unique |
|legalBase\_id |FK |Index |
|consentSource\_id |FK |Index |
|person\_id, consentPurpose\_id |FK, FK |Unique |

## Replication Flags

* Area Management controlled table. Contents replicated to satellites and traveller databases.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

