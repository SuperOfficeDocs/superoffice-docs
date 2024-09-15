---
uid: table-ContInt
title: ContInt table
description: ContInt list table. List-text of all valid contact interest types.
so.generated: true
keywords: database table ContInt
so.topic: reference
so.envir: onsite, online
---

# ContInt Table (70)

ContInt MDO list item table.
ContInt list table. List-text of all valid contact interest types.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|ContInt\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ContInt table relationship diagram](./media/ContInt.png)

[!include[details](./includes/contint.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|ContInt\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[contactinterest](contactinterest.md)  |Link-table between contact and interests in ContInt |
|[ContIntGroupLink](contintgrouplink.md)  |User group link table for ContInt, for MDO item hiding |
|[ContIntHeadingLink](contintheadinglink.md)  |Heading link table for ContInt, for MDO headers |
|[s\_link](s-link.md)  |Links in messages to measure success rate of a campaign. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

