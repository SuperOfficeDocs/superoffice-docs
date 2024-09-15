---
uid: table-ProductCategoryGroupLink
title: ProductCategoryGroupLink table
description: User group link table for ProductCategory, for MDO item hiding
so.generated: true
keywords: database table ProductCategoryGroupLink
so.topic: reference
so.envir: onsite, online
---

# ProductCategoryGroupLink Table (409)

User group link table for ProductCategory, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|productcategorygrouplink\_id|Primary key|PK| |
|productcategory\_id|Link to ProductCategory list table|FK [ProductCategory](productcategory.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProductCategoryGroupLink table relationship diagram](./media/ProductCategoryGroupLink.png)

[!include[details](./includes/productcategorygrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|productcategorygrouplink\_id |PK |Clustered, Unique |
|productcategory\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ProductCategory](productcategory.md)  |List for the ProductCategory field of the Product table (Quote Management) |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

