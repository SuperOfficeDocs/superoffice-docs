---
uid: table-freetextwords
title: freetextwords table
description: This table contains the word list (automatically updated by the indexer) for the free-text search. Words are in UPPERCASE and truncated to 9 significant characters. Indexed words, dynamically updated by the freetext index
so.generated: true
keywords:
  - "database"
  - "freetextwords"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# freetextwords Table (45)

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

## Replication Flags

* Copy to satellite and travel prototypes.

## Security Flags

* No access control via user's Role.

