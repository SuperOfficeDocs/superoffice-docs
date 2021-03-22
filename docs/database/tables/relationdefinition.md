---
uid: table-relationdefinition
title: relationdefinition table
description: Definition of a relation. This table defines the relations that can exist in the database. Each relation has an active text and a passive text. The table RelationTarget specifies which pairs of tables this relation can connect.  Use of the active and passive texts is dependent on which direction the relation is viewed in, e.g., active text = &quot;Owns&quot; and passive text = &quot;Is owned by&quot;.
so.generated: true
keywords:
  - "database"
  - "relationdefinition"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# relationdefinition Table (48)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|reldef\_id|Primary key|PK| |
|name|Active text|String(239)|&#x25CF;|
|rank|Rank order |UShort|&#x25CF;|
|tooltip|Tooltip or other description|String(254)|&#x25CF;|
|deleted|0 -&gt; record is active 1 -&gt; record is &apos;deleted&apos; and should not be shown in lists|UShort|&#x25CF;|
|passive\_text|Text used in passive direction|String(254)|&#x25CF;|
|defcomment|Comment|String(254)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![relationdefinition table relationship diagram](./media/relationdefinition.png)

[!include[details](./includes/relationdefinition.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|reldef\_id |PK |Clustered, Unique |

## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

