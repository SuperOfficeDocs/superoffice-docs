---
uid: table-Salutation
title: Salutation table
description: Academic title for Person
so.generated: true
keywords: database table Salutation
so.topic: reference
so.envir: onsite, online
---

# Salutation Table (219)

Salutation MDO list item table.
Academic title for Person

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|Salutation\_Id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![Salutation table relationship diagram](./media/Salutation.png)

[!include[details](./includes/salutation.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|Salutation\_Id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[SalutationGroupLink](salutationgrouplink.md)  |User group link table for Salutation, for MDO item hiding |
|[SalutationHeadingLink](salutationheadinglink.md)  |Heading link table for Salutation, for MDO headers |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

