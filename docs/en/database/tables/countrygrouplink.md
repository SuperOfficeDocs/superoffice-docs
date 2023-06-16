---
uid: table-CountryGroupLink
title: CountryGroupLink table
description: User group link table for Country, for MDO item hiding
so.generated: true
keywords: database table CountryGroupLink
so.topic: reference
so.envir: onsite, online
---

# CountryGroupLink Table (20)

User group link table for Country, for MDO item hiding

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|countrygrouplink\_id|Primary key|PK| |
|country\_id|Link to Country list table|FK [country](country.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![CountryGroupLink table relationship diagram](./media/CountryGroupLink.png)

[!include[details](./includes/countrygrouplink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|countrygrouplink\_id |PK |Clustered, Unique |
|country\_id |FK |Index |
|group\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[country](country.md)  |Country information |
|[UserGroup](usergroup.md)  |Secondary user groups |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

