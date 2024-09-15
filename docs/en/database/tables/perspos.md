---
uid: table-PersPos
title: PersPos table
description: PersPos list table. Contact person position list
so.generated: true
keywords: database table PersPos
so.topic: reference
so.envir: onsite, online
---

# PersPos Table (76)

PersPos MDO list item table.
PersPos list table. Contact person position list

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|PersPos\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PersPos table relationship diagram](./media/PersPos.png)

[!include[details](./includes/perspos.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|PersPos\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[person](person.md)  |Persons in a company or an organizations. All associates have a corresponding person record |
|[PersPosGroupLink](persposgrouplink.md)  |User group link table for PersPos, for MDO item hiding |
|[PersPosHeadingLink](persposheadinglink.md)  |Heading link table for PersPos, for MDO headers |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

