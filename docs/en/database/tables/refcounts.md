---
uid: table-RefCounts
title: RefCounts table
description: Number counter for all tables that generate numbers, e.g. templates, contacts...   This table is used for the number allocation system and should not be confused with sequence, used for allocating internal ID&apos;s. This table is replicated during generation of satellites and during local update for travellers, using special logic. By default it contains rows for the SuperOffice standard counters, including one row for each DocTemplate record.  It is permissible to add new rows to this table, and such records are maintainable through the Maintenance client.  Changing the contents of the standard records is not recommended. 
so.generated: true
keywords: database table RefCounts
so.topic: reference
so.envir: onsite, online
---

# RefCounts Table (171)

Number counter for all tables that generate numbers, e.g. templates, contacts...   This table is used for the number allocation system and should not be confused with sequence, used for allocating internal ID&apos;s. This table is replicated during generation of satellites and during local update for travellers, using special logic. By default it contains rows for the SuperOffice standard counters, including one row for each DocTemplate record.  It is permissible to add new rows to this table, and such records are maintainable through the Maintenance client.  Changing the contents of the standard records is not recommended. 

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|RefCounts\_id|Primary key|PK| |
|fieldId|The field (and thereby table) this counter is assigned to|FieldId| |
|recordId|Record id in target table, used when there are separate counters for each target record|Id| |
|currentValue|Current value of counter|Id| |
|travelPrefix|size of prefix for Travel use of ths counter|UInt| |
|satPrefix|size of prefix for Satellite use of this counter|UInt| |
|flags|Unique, active, read-only, allow blank, …|Enum [RefcountFlags](enums/refcountflags.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![RefCounts table relationship diagram](./media/RefCounts.png)

[!include[details](./includes/refcounts.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|RefCounts\_id |PK |Clustered, Unique |
|fieldId |FieldId |Index |
|recordId |Id |Index |
|fieldId, recordId |FieldId, Id |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |
|[RefCountRange](refcountrange.md)  |Number allocation system, for keeping track of ranges of numbers loaned out to travel and satellite databases |


## Replication Flags

* Area Management controlled table. Contents replicated to satellites and traveller databases.
* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

