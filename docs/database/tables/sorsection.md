---
uid: sorsection
title: sorsection table
description: SuperOffice reporter data
so.generated: true
keywords:
  - "database"
  - "sorsection"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# SORSection Table (177)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|SORSection\_id|Primary key|PK| |
|SORTemplate\_id|Template ID|FK [SORTemplate](SORTemplate.md)| |
|sectionType|reportheader, reportfooter, pageheader, pagefooter, detail, groupheader(1-3), groupfooter(1-3)|String(19)| |
|height|Section height in twips|UInt| |
|groupingField|Name of field used for grouping, ig group section|String(29)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SORSection table relationship diagram](media\SORSection.png)

[!include[details](./includes/SORSection.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|SORSection\_id |PK |Clustered, Unique |
|SORTemplate\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

