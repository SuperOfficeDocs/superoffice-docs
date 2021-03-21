---
uid: table-dictionary-base
title: dictionary\_base table
description: Language catalog for the ejournal dictionaries (automatic proof reading of message text etc)
so.generated: true
keywords:
  - "database"
  - "dictionary_base"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# dictionary\_base Table (359)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|name|The name of the language|String(32)| |
|code|Language code name (no, en)|String(8)| |
|flags|A bitmask of dictionary flags|Int| |


![dictionary_base table relationship diagram](./media/dictionary_base.png)

[!include[details](./includes/dictionary-base.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

