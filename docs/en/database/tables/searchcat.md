---
uid: table-SearchCat
title: SearchCat table
description: SearchCat list table
so.generated: true
keywords: database table SearchCat
so.topic: reference
so.envir: onsite, online
---

# SearchCat Table (106)

SearchCat MDO list item table.
SearchCat list table

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|SearchCat\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![SearchCat table relationship diagram](./media/SearchCat.png)

[!include[details](./includes/searchcat.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|SearchCat\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[SearchCatGroupLink](searchcatgrouplink.md)  |User group link table for SearchCat, for MDO item hiding |
|[SearchCatHeadingLink](searchcatheadinglink.md)  |Heading link table for SearchCat, for MDO headers |
|[selection](selection.md)  |Selections |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

