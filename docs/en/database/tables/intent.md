---
uid: table-Intent
title: Intent table
description: Intent list for SAINT. More information regarding SuperOffice Sales Intelligence on http;//techdoc.superoffice.com 
so.generated: true
keywords: database table Intent
so.topic: reference
so.envir: onsite, online
---

# Intent Table (216)

Intent MDO list item table.
Intent list for SAINT. More information regarding SuperOffice Sales Intelligence on http;//techdoc.superoffice.com 

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|Intent\_Id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![Intent table relationship diagram](./media/Intent.png)

[!include[details](./includes/intent.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|Intent\_Id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[CounterValue](countervalue.md)  |Visible for rights |
|[DocTmpl](doctmpl.md)  |DocTmpl list table. Describes templates available for writing new documents. |
|[IntentGroupLink](intentgrouplink.md)  |User group link table for Intent, for MDO item hiding |
|[IntentHeadingLink](intentheadinglink.md)  |Heading link table for Intent, for MDO headers |
|[Task](task.md)  |Task list table, activity types, like Phone, Meeting |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

