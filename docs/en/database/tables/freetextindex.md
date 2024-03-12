---
uid: table-freetextindex
title: freetextindex table
description: This is the index table for the free text search function. Each word in FreeTextWords can have multiple occurrences in this table. Each record in this table points to one occurrence of the word, and points to both the table in which the word occurs (which might be contact or text), and also a pointer to the owner table (which is one of contact, person, project, appointment or sale). 
so.generated: true
keywords: database table freetextindex
so.topic: reference
so.envir: onsite, online
---

# freetextindex Table (46)

This is the index table for the free text search function. Each word in FreeTextWords can have multiple occurrences in this table. Each record in this table points to one occurrence of the word, and points to both the table in which the word occurs (which might be contact or text), and also a pointer to the owner table (which is one of contact, person, project, appointment or sale). 

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|freetextindex\_id|Primary key|PK| |
|freetextwords\_id|Reference to word|FK [freetextwords](freetextwords.md)| |
|table\_id|Source table number - could be main (contact, person, etc) or sub-tables like address, email|TableNumber| |
|record\_id|Source record - the row that contains the word. Might be contact record, or an address or phone|RecordId| |
|ownertable\_id|Logical source table (high-level), like contact or project|TableNumber| |
|ownerrecord\_id|Logical source record. The contact, project, sale that the source belongs to.|RecordId| |
|infile|Word found in file (0=word found in database)|UShort| |
|contact\_id|Set for contacts and person records to allow cross-table free-text searches. 0 for non-contact, non-person|FK [contact](contact.md)| |


![freetextindex table relationship diagram](./media/freetextindex.png)

[!include[details](./includes/freetextindex.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|freetextindex\_id |PK |Unique |
|table\_id, record\_id |TableNumber, RecordId |Index |
|freetextwords\_id, ownertable\_id |FK, TableNumber |Clustered |
|contact\_id |FK |Index |
|ownerrecord\_id, ownertable\_id, freetextwords\_id |RecordId, TableNumber, FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[contact](contact.md)  |Companies and Organizations.   This table features a special record containing information about the contact that owns the database.   |
|[freetextwords](freetextwords.md)  |This table contains the word list (automatically updated by the indexer) for the free-text search. Words are in UPPERCASE and truncated to 9 significant characters. Indexed words, dynamically updated by the freetext index |


## Replication Flags

* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

