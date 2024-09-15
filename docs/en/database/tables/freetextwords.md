---
uid: table-freetextwords
title: freetextwords table
description: This table contains the word list (automatically updated by the indexer) for the free-text search. Words are in UPPERCASE and truncated to 9 significant characters. Indexed words, dynamically updated by the freetext index
so.generated: true
keywords: database table freetextwords
so.topic: reference
so.envir: onsite, online
---

# freetextwords Table (45)

This table contains the word list (automatically updated by the indexer) for the free-text search. Words are in UPPERCASE and truncated to 9 significant characters. Indexed words, dynamically updated by the freetext index

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|freetextwords\_id|Primary key|PK| |
|word|Indexed word|String(19)| |
|soundEx|Soundex form of word using Metaphone algorithm, for sounds-like searching|String(9)| |


![freetextwords table relationship diagram](./media/freetextwords.png)

[!include[details](./includes/freetextwords.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|freetextwords\_id |PK |Clustered, Unique |
|word |String(19) |Index |
|soundEx |String(9) |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[freetextindex](freetextindex.md)  |This is the index table for the free text search function. Each word in FreeTextWords can have multiple occurrences in this table. Each record in this table points to one occurrence of the word, and points to both the table in which the word occurs (which might be contact or text), and also a pointer to the owner table (which is one of contact, person, project, appointment or sale).  |


## Replication Flags

* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

