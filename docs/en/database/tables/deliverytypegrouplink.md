---
uid: table-DeliveryTypeGroupLink
title: DeliveryTypeGroupLink table
description: User group link table for DeliveryType, for MDO item hiding
so.generated: true
keywords: database table DeliveryTypeGroupLink
so.topic: reference
so.envir: onsite, online
---

# DeliveryTypeGroupLink Table (437)

User group link table for DeliveryType, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|deliverytypegrouplink\_id|Primary key|PK| |
|deliverytype\_id|Link to DeliveryType list table|FK [DeliveryType](deliverytype.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![DeliveryTypeGroupLink table relationship diagram](./media/DeliveryTypeGroupLink.png)

[!include[details](./includes/deliverytypegrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|deliverytypegrouplink\_id |PK |Clustered, Unique |
|deliverytype\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[DeliveryType](deliverytype.md)  |The list of Delivery types, in the internal product register |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

