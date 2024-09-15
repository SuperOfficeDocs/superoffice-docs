---
uid: table-Business
title: Business table
description: Business list table
so.generated: true
keywords: database table Business
so.topic: reference
so.envir: onsite, online
---

# Business Table (61)

Business MDO list item table.
Business list table

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|business\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order |UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![Business table relationship diagram](./media/Business.png)

[!include[details](./includes/business.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|business\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[BusinessGroupLink](businessgrouplink.md)  |User group link table for Business, for MDO item hiding |
|[BusinessHeadingLink](businessheadinglink.md)  |Heading link table for Business, for MDO headers |
|[contact](contact.md)  |Companies and Organizations.   This table features a special record containing information about the contact that owns the database.   |
|[person](person.md)  |Persons in a company or an organizations. All associates have a corresponding person record |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

