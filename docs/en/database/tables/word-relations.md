---
uid: table-word_relations
title: word_relations table
description: This table shows which word are used in which FAQ entry, and how many times            they are used in each
so.generated: true
keywords: database table word_relations
so.topic: reference
so.envir: onsite, online
---

# word\_relations Table (355)

This table shows which word are used in which FAQ entry, and how many times            they are used in each

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|entry\_word\_id|A reference to the id of the word|FK [kb_entry_words](kb-entry-words.md)| |
|entry\_id|A reference to the id of the entry|FK [kb_entry](kb-entry.md)| |
|used|Indicates how many times this word is used in the FAQ entry|Int| |
|origin|Indicates if it is an entry word (0) or a category word (1).|Short| |


![word_relations table relationship diagram](./media/word_relations.png)

[!include[details](./includes/word-relations.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|entry\_word\_id |FK |Index |
|entry\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[kb\_entry](kb-entry.md)  |This table contains FAQ entries. |
|[kb\_entry\_words](kb-entry-words.md)  |This table contains all the words and how many times the are refered                  to in the FAQ entires |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

