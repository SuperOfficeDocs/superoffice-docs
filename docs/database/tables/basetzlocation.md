---
uid: basetzlocation
title: basetzlocation table
description: Time zone location for the database (how tz-related datetimes should be stored in the database)
so.generated: true
keywords:
  - "database"
  - "basetzlocation"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# BaseTZLocation Table (248)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|BaseTZLocation\_id|Primary key|PK| |
|TZLocation\_id|Country that this timezone location is defined for|FK [TZLocation](TZLocation.md)| |
|validFrom|When is this tzLocation valid from, as THE database timezonelocation|DateTime| |
|databaseId|Actually travelcurrent.current_id, the id of the database this basetimezonelocation is meant for|Id| |
|description|Descriptive text|String(254)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![BaseTZLocation table relationship diagram](media\BaseTZLocation.png)

[!include[details](./includes/BaseTZLocation.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|BaseTZLocation\_id |PK |Clustered, Unique |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

