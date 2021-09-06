---
uid: table-userpreference
title: userpreference table
description: Preference system. If deflevel is set to 5; the user may change the preferences
so.generated: true
keywords:
  - "database"
  - "UserPreference"
so.date: 03.22.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# userpreference Table (56)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|userpreference\_id|Primary key|PK| |
|deflevel|The level: 0=hard default, 1=systemwide, 2=database, 3=group, 4=individual|Enum [preferencelevel](enums/preferencelevel.md)| |
|maxlevel|Highest override level allowed|Enum [preferencelevel](enums/preferencelevel.md)| |
|owner\_id|level=3: group; level=4: associate|Id| |
|prefsection|Preference section name|String(199)| |
|prefkey|Preference key name|String(199)| |
|prefvalue|Preference value|String(2046)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![UserPreference table relationship diagram](./media/UserPreference.png)

[!include[details](./includes/UserPreference.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|userpreference\_id |PK |Clustered, Unique |
|deflevel |Enum |Index |
|owner\_id |Id |Index |
|prefsection |String(199) |Index |
|prefkey |String(199) |Index |
|prefsection, prefkey, deflevel, owner\_id |String(199), String(199), Enum, Id |Index |

## Replication Flags

* Area Management controlled table. Contents replicated to satellites and traveller databases.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

