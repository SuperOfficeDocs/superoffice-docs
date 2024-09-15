---
uid: table-ProductTypeHeadingLink
title: ProductTypeHeadingLink table
description: Heading link table for ProductType, for MDO item headings
so.generated: true
keywords: database table ProductTypeHeadingLink
so.topic: reference
so.envir: onsite, online
---

# ProductTypeHeadingLink Table (416)

Heading link table for ProductType, for MDO item headings

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|producttypeheadinglink\_id|Primary key|PK| |
|producttype\_id|Link to ProductType list table|FK [ProductType](producttype.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProductTypeHeadingLink table relationship diagram](./media/ProductTypeHeadingLink.png)

[!include[details](./includes/producttypeheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|producttypeheadinglink\_id |PK |Clustered, Unique |
|producttype\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[ProductType](producttype.md)  |List for the ProductType field of the Product table (Quote Management) |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

