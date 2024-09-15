---
uid: table-TZStdRule
title: TZStdRule table
description: Time zone rule for standard time
so.generated: true
keywords: database table TZStdRule
so.topic: reference
so.envir: onsite, online
---

# TZStdRule Table (246)

Time zone rule for standard time

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|TZStdRule\_id|Primary key|PK| |
|TZLocationId|Location that this rule is valid for - one location has at least one rule; multiple rules are discerned by their validFrom dates|FK [TZLocation](tzlocation.md)| |
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

[!include[details](./includes/tzstdrule.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|TZStdRule\_id |PK |Clustered, Unique |
|TZLocationId |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[TZLocation](tzlocation.md)  |Time zone location |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

