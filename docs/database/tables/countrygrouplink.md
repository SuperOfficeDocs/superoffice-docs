---
uid: countrygrouplink
title: countrygrouplink table
description: User group link table for Country, for MDO item hiding
so.generated: true
keywords:
  - "database"
  - "countrygrouplink"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# CountryGroupLink Table (20)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|countrygrouplink\_id|Primary key|PK| |
|country\_id|Link to Country list table|FK [country](country.md)| |
|group\_id|Link to Group table|FK [UserGroup](UserGroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![CountryGroupLink table relationship diagram](media\CountryGroupLink.png)

[!include[details](./includes/CountryGroupLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|countrygrouplink\_id |PK |Clustered, Unique |
|country\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

