---
uid: table-tzstdrule
title: tzstdrule table
description: Time zone rule for standard time
so.generated: true
keywords:
  - "database"
  - "TZStdRule"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# tzstdrule Table (246)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|TZStdRule\_id|Primary key|PK| |
|TZLocationId|Location that this rule is valid for - one location has at least one rule; multiple rules are discerned by their validFrom dates|FK [tzlocation](tzlocation.md)| |
|validFrom|Date this rule is valid from|DateTime| |
|bias|number of minutes bias relative to UTC time|Short| |
|description|Description, for identifying the rule in SoAdmin|String(2047)|&#x25CF;|
|isBuiltIn|Is this row part of SuperOffice priming data|Bool|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![TZStdRule table relationship diagram](./media/TZStdRule.png)

[!include[details](./includes/TZStdRule.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|TZStdRule\_id |PK |Clustered, Unique |
|TZLocationId |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

