---
uid: table-relationtarget
title: relationtarget table
description: Definition of targets for a relation. Links a relation definition (RelDef) to source and target tables. In general, a relation can be created between any pair of tables. This table is used for specifying which table pairs a particular relation can be used for. A relation definition should have at least one row in this table, and can have more. Note; The 5.0 Maintenance and GUI only support contact and person as valid values for the source_table and destination_table fields, in any combination. Other relations will not be shown, and relation definitions pointing to other tables will not be editable from the Maintenance GUI; however, nothing will crash.
so.generated: true
keywords: database table relationtarget
so.topic: reference
so.envir: onsite, online
---

# relationtarget Table (51)

Definition of targets for a relation. Links a relation definition (RelDef) to source and target tables. In general, a relation can be created between any pair of tables. This table is used for specifying which table pairs a particular relation can be used for. A relation definition should have at least one row in this table, and can have more. Note; The 5.0 Maintenance and GUI only support contact and person as valid values for the source_table and destination_table fields, in any combination. Other relations will not be shown, and relation definitions pointing to other tables will not be editable from the Maintenance GUI; however, nothing will crash.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|reltarget\_id|Primary key|PK| |
|reldef\_id|Reference to definition|FK [relationdefinition](relationdefinition.md)| |
|source\_table|Source table number (contact/person in 5.0)|TableNumber| |
|destination\_table|Target table number (contact/person in 5.0)|TableNumber| |
|bidirectional|Is relation bidirectional|UShort|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![relationtarget table relationship diagram](./media/relationtarget.png)

[!include[details](./includes/relationtarget.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|reltarget\_id |PK |Clustered, Unique |
|reldef\_id |FK |Index |
|source\_table |TableNumber |Index |
|destination\_table |TableNumber |Index |
|bidirectional |UShort |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[relationdefinition](relationdefinition.md)  |Definition of a relation. This table defines the relations that can exist in the database. Each relation has an active text and a passive text. The table RelationTarget specifies which pairs of tables this relation can connect.  Use of the active and passive texts is dependent on which direction the relation is viewed in, e.g., active text = &quot;Owns&quot; and passive text = &quot;Is owned by&quot;. |


## Replication Flags

* Replicate changes DOWN from central to satellites and travellers.
* Replicate changes UP from satellites and travellers back to central.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

