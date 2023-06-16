---
uid: table-PMembType
title: PMembType table
description: PMembType list table. List text of titles (member types) for project members.
so.generated: true
keywords: database table PMembType
so.topic: reference
so.envir: onsite, online
---

# PMembType Table (91)

PMembType MDO list item table.
PMembType list table. List text of titles (member types) for project members.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|PMembType\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PMembType table relationship diagram](./media/PMembType.png)

[!include[details](./includes/pmembtype.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|PMembType\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[PMembTypeGroupLink](pmembtypegrouplink.md)  |User group link table for PMembType, for MDO item hiding |
|[PMembTypeHeadingLink](pmembtypeheadinglink.md)  |Heading link table for PMembType, for MDO headers |
|[projectmember](projectmember.md)  |Project members. Link-table between person and project |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

