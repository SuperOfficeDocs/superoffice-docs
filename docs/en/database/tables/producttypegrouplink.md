---
uid: table-ProductTypeGroupLink
title: ProductTypeGroupLink table
description: User group link table for ProductType, for MDO item hiding
so.generated: true
keywords: database table ProductTypeGroupLink
so.topic: reference
so.envir: onsite, online
---

# ProductTypeGroupLink Table (415)

User group link table for ProductType, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|producttypegrouplink\_id|Primary key|PK| |
|producttype\_id|Link to ProductType list table|FK [ProductType](producttype.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProductTypeGroupLink table relationship diagram](./media/ProductTypeGroupLink.png)

[!include[details](./includes/producttypegrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|producttypegrouplink\_id |PK |Clustered, Unique |
|producttype\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ProductType](producttype.md)  |List for the ProductType field of the Product table (Quote Management) |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

