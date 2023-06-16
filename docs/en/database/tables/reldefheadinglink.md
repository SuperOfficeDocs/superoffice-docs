---
uid: table-RelDefHeadingLink
title: RelDefHeadingLink table
description: Heading link table for RelDef, for MDO headers
so.generated: true
keywords: database table RelDefHeadingLink
so.topic: reference
so.envir: onsite, online
---

# RelDefHeadingLink Table (50)

Heading link table for RelDef, for MDO headers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|reldefheadinglink\_id|Primary key|PK| |
|reldef\_id|Link to RelDef list table|FK [relationdefinition](relationdefinition.md)| |
|heading\_id|Link to Heading table|FK [Heading](heading.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![RelDefHeadingLink table relationship diagram](./media/RelDefHeadingLink.png)

[!include[details](./includes/reldefheadinglink.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|reldefheadinglink\_id |PK |Clustered, Unique |
|reldef\_id |FK |Index |
|heading\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[Heading](heading.md)  |Heading items for all MDO lists, lists that are grouped and filtered. |
|[relationdefinition](relationdefinition.md)  |Definition of a relation. This table defines the relations that can exist in the database. Each relation has an active text and a passive text. The table RelationTarget specifies which pairs of tables this relation can connect.  Use of the active and passive texts is dependent on which direction the relation is viewed in, e.g., active text = &quot;Owns&quot; and passive text = &quot;Is owned by&quot;. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

