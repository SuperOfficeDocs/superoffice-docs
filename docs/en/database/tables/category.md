---
uid: table-Category
title: Category table
description: Category list table
so.generated: true
keywords: database table Category
so.topic: reference
so.envir: onsite, online
---

# Category Table (64)

Category MDO list item table.
Category list table

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|Category\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order |UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |
|CategoryFamily\_id|Optional link to family, for grouping things like multiple kinds of customer category under family &apos;customer&apos;|FK [CategoryFamily](categoryfamily.md)|&#x25CF;|


![Category table relationship diagram](./media/Category.png)

[!include[details](./includes/category.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|Category\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[CategoryFamily](categoryfamily.md)  |Grouping table so that multiple company categories can be grouped under one term; to simplify searching for things like &apos;all customers&apos; |
|[CategoryGroupLink](categorygrouplink.md)  |User group link table for Category, for MDO item hiding |
|[CategoryHeadingLink](categoryheadinglink.md)  |Heading link table for Category, for MDO headers |
|[contact](contact.md)  |Companies and Organizations.   This table features a special record containing information about the contact that owns the database.   |
|[person](person.md)  |Persons in a company or an organizations. All associates have a corresponding person record |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

