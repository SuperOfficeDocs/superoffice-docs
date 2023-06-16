---
uid: table-kb_entry_words
title: kb_entry_words table
description: This table contains all the words and how many times the are refered                  to in the FAQ entires
so.generated: true
keywords: database table kb_entry_words
so.topic: reference
so.envir: onsite, online
---

# kb\_entry\_words Table (354)

This table contains all the words and how many times the are refered                  to in the FAQ entires

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|word|A word found in a kb_entry|String(63)| |
|score|Indicates how many occurences of this word we have|Int|&#x25CF;|
|origin|Indicates if it is an entry word (0) or a category word (1).|Short| |


![kb_entry_words table relationship diagram](./media/kb_entry_words.png)

[!include[details](./includes/kb-entry-words.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|word |String(63) |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[word\_relations](word-relations.md)  |This table shows which word are used in which FAQ entry, and how many times            they are used in each |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

