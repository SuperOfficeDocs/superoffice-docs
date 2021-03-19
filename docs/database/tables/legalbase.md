---
uid: legalbase
title: legalbase table
description: Legal base for GDPR (Article 6)
so.generated: true
keywords:
  - "database"
  - "legalbase"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# LegalBase Table (464)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|legalbase\_id|Primary key|PK| |
|name|The list item|String(4000)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|The tooltip for the list item|String(4000)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|key|The list item key, to be recognized by application logic|String(255)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![LegalBase table relationship diagram](media\LegalBase.png)

[!include[details](./includes/LegalBase.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|legalbase\_id |PK |Clustered, Unique |
|key |String(255) |Unique |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

