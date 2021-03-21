---
uid: table-projecttypestatuslink
title: projecttypestatuslink table
description: Many-many link table between project type and status, similar to sale type-stage link; and an anchor point for guide items
so.generated: true
keywords:
  - "database"
  - "ProjectTypeStatusLink"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# projecttypestatuslink Table (213)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|ProjectTypeStatusLink\_id|Primary key|PK| |
|projType\_id|Link to project type|FK [projtype](projtype.md)| |
|projStatus\_id|Link to project status|FK [projstatus](projstatus.md)| |
|rank|Rank order |UShort|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ProjectTypeStatusLink table relationship diagram](./media/ProjectTypeStatusLink.png)

[!include[details](./includes/ProjectTypeStatusLink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|ProjectTypeStatusLink\_id |PK |Clustered, Unique |
|projType\_id, projStatus\_id |FK, FK |Index |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

