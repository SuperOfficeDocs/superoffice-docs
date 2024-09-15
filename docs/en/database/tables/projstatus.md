---
uid: table-ProjStatus
title: ProjStatus table
description: ProjStatus list table. Project status
so.generated: true
keywords: database table ProjStatus
so.topic: reference
so.envir: onsite, online
---

# ProjStatus Table (88)

ProjStatus MDO list item table.
ProjStatus list table. Project status

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|ProjStatus\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProjStatus table relationship diagram](./media/ProjStatus.png)

[!include[details](./includes/projstatus.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|ProjStatus\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[project](project.md)  |Projects |
|[ProjectTypeStatusLink](projecttypestatuslink.md)  |Many-many link table between project type and status, similar to sale type-stage link; and an anchor point for guide items |
|[ProjStatusGroupLink](projstatusgrouplink.md)  |User group link table for ProjStatus, for MDO item hiding |
|[ProjStatusHeadingLink](projstatusheadinglink.md)  |Heading link table for ProjStatus, for MDO headers |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

