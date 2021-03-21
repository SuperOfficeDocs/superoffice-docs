---
uid: table-category
title: category table
description: Category list table
so.generated: true
keywords:
  - "database"
  - "Category"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# category Table (64)

category MDO list item table.
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
|CategoryFamily\_id|Optional link to family, for grouping things like multiple kinds of customer category under family &apos;customer&apos;|FK [categoryfamily](categoryfamily.md)|&#x25CF;|


![Category table relationship diagram](./media/Category.png)

[!include[details](./includes/Category.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|Category\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

