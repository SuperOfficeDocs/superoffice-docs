---
uid: table-preference
title: preference table
description: Not quite obsolete preference table; historical info mostly. From 6.1 this table now holds an upgrade stamp.
so.generated: true
keywords: database table preference
so.topic: reference
so.envir: onsite, online
---

# preference Table (22)

Not quite obsolete preference table; historical info mostly. From 6.1 this table now holds an upgrade stamp.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|preference\_id|Primary key|PK| |
|type|Preference type|ShortId| |
|pdata|Changed to string[255]|String(254)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![preference table relationship diagram](./media/preference.png)

[!include[details](./includes/preference.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|preference\_id |PK |Clustered, Unique |
|type, preference\_id |ShortId, PK |Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |


## Replication Flags

* Area Management controlled table. Contents replicated to satellites and traveller databases.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

