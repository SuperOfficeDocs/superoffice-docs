---
uid: table-ProductFamilyHeadingLink
title: ProductFamilyHeadingLink table
description: Heading link table for ProductFamily, for MDO item headings
so.generated: true
keywords: database table ProductFamilyHeadingLink
so.topic: reference
so.envir: onsite, online
---

# ProductFamilyHeadingLink Table (413)

Heading link table for ProductFamily, for MDO item headings

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|productfamilyheadinglink\_id|Primary key|PK| |
|productfamily\_id|Link to ProductFamily list table|FK [ProductFamily](productfamily.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProductFamilyHeadingLink table relationship diagram](./media/ProductFamilyHeadingLink.png)

[!include[details](./includes/productfamilyheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|productfamilyheadinglink\_id |PK |Clustered, Unique |
|productfamily\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[ProductFamily](productfamily.md)  |List for the ProductFamily field of the Product table (Quote Management) |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

