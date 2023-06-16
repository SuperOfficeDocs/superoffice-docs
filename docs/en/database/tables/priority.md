---
uid: table-Priority
title: Priority table
description: Priority list table. Used with appointments; low, high.
so.generated: true
keywords: database table Priority
so.topic: reference
so.envir: onsite, online
---

# Priority Table (79)

Priority MDO list item table.
Priority list table. Used with appointments; low, high.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|Priority\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![Priority table relationship diagram](./media/Priority.png)

[!include[details](./includes/priority.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|Priority\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[appointment](appointment.md)  |Tasks, appointments, followups, phone calls; and documents (document_id != 0). An appointment always has a corresponding record in VisibleFor specifying who may see this.  |
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[PriorityGroupLink](prioritygrouplink.md)  |User group link table for Priority, for MDO item hiding |
|[PriorityHeadingLink](priorityheadinglink.md)  |Heading link table for Priority, for MDO headers |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

