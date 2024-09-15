---
uid: table-PaymentTypeGroupLink
title: PaymentTypeGroupLink table
description: User group link table for PaymentType, for MDO item hiding
so.generated: true
keywords: database table PaymentTypeGroupLink
so.topic: reference
so.envir: onsite, online
---

# PaymentTypeGroupLink Table (431)

User group link table for PaymentType, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|paymenttypegrouplink\_id|Primary key|PK| |
|paymenttype\_id|Link to PaymentType list table|FK [PaymentType](paymenttype.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![PaymentTypeGroupLink table relationship diagram](./media/PaymentTypeGroupLink.png)

[!include[details](./includes/paymenttypegrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|paymenttypegrouplink\_id |PK |Clustered, Unique |
|paymenttype\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[PaymentType](paymenttype.md)  |The list of payment types, in the internal product register |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

