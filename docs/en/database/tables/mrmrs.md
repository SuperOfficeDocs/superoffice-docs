---
uid: table-MrMrs
title: MrMrs table
description: MrMrs list table. List of salutations.
so.generated: true
keywords: database table MrMrs
so.topic: reference
so.envir: onsite, online
---

# MrMrs Table (94)

MrMrs MDO list item table.
MrMrs list table. List of salutations.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|MrMrs\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![MrMrs table relationship diagram](./media/MrMrs.png)

[!include[details](./includes/mrmrs.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|MrMrs\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[MrMrsGroupLink](mrmrsgrouplink.md)  |User group link table for MrMrs, for MDO item hiding |
|[MrMrsHeadingLink](mrmrsheadinglink.md)  |Heading link table for MrMrs, for MDO headers |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

