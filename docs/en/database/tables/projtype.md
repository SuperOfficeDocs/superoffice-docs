---
uid: table-ProjType
title: ProjType table
description: ProjType list table. List of valid Project types.
so.generated: true
keywords: database table ProjType
so.topic: reference
so.envir: onsite, online
---

# ProjType Table (85)

ProjType MDO list item table.
ProjType list table. List of valid Project types.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|ProjType\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|projectDuration|Expected duration of project, in given units|Int|&#x25CF;|
|durationUnit|Units for the duration|Enum [DurationUnit](enums/durationunit.md)|&#x25CF;|
|hasGuide|Does this project type have a guide attached|Bool|&#x25CF;|
|isAutoAdvance|Does the project status advance automatically, when the last guided activity in a status is completed?|Bool|&#x25CF;|


![ProjType table relationship diagram](./media/ProjType.png)

[!include[details](./includes/projtype.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|ProjType\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[project](project.md)  |Projects |
|[ProjectTypeStatusLink](projecttypestatuslink.md)  |Many-many link table between project type and status, similar to sale type-stage link; and an anchor point for guide items |
|[ProjTypeGroupLink](projtypegrouplink.md)  |User group link table for ProjType, for MDO item hiding |
|[ProjTypeHeadingLink](projtypeheadinglink.md)  |Heading link table for ProjType, for MDO headers |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

