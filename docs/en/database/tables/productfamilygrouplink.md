---
uid: table-ProductFamilyGroupLink
title: ProductFamilyGroupLink table
description: User group link table for ProductFamily, for MDO item hiding
so.generated: true
keywords: database table ProductFamilyGroupLink
so.topic: reference
so.envir: onsite, online
---

# ProductFamilyGroupLink Table (412)

User group link table for ProductFamily, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|productfamilygrouplink\_id|Primary key|PK| |
|productfamily\_id|Link to ProductFamily list table|FK [ProductFamily](productfamily.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProductFamilyGroupLink table relationship diagram](./media/ProductFamilyGroupLink.png)

[!include[details](./includes/productfamilygrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|productfamilygrouplink\_id |PK |Clustered, Unique |
|productfamily\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[ProductFamily](productfamily.md)  |List for the ProductFamily field of the Product table (Quote Management) |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

