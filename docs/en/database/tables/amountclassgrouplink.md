---
uid: table-AmountClassGroupLink
title: AmountClassGroupLink table
description: User group link table for AmountClass, for MDO item hiding
so.generated: true
keywords: database table AmountClassGroupLink
so.topic: reference
so.envir: onsite, online
---

# AmountClassGroupLink Table (226)

User group link table for AmountClass, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|amountclassgrouplink\_id|Primary key|PK| |
|amountclass\_id|Link to AmountClass list table|FK [AmountClass](amountclass.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![AmountClassGroupLink table relationship diagram](./media/AmountClassGroupLink.png)

[!include[details](./includes/amountclassgrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|amountclassgrouplink\_id |PK |Clustered, Unique |
|amountclass\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[AmountClass](amountclass.md)  |Amount Class list for SuperOffice Sales Intelligence (Saint) - used to group sales by amounts, into bins (low --&gt; high) called amount classes. More information regarding SuperOffice Sales Intelligence on http://techdoc.superoffice.com  |
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

