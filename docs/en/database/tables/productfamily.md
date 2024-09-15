---
uid: table-ProductFamily
title: ProductFamily table
description: List for the ProductFamily field of the Product table (Quote Management)
so.generated: true
keywords: database table ProductFamily
so.topic: reference
so.envir: onsite, online
---

# ProductFamily Table (411)

ProductFamily MDO list item table.
List for the ProductFamily field of the Product table (Quote Management)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|productfamily\_id|Primary key|PK| |
|name|The list item|String(239)| |
|rank|Rank order|UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProductFamily table relationship diagram](./media/ProductFamily.png)

[!include[details](./includes/productfamily.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|productfamily\_id |PK |Clustered, Unique |
|name |String(239) |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ProductFamilyGroupLink](productfamilygrouplink.md)  |User group link table for ProductFamily, for MDO item hiding |
|[ProductFamilyHeadingLink](productfamilyheadinglink.md)  |Heading link table for ProductFamily, for MDO item headings |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

