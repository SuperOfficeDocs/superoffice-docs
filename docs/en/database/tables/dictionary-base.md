---
uid: table-dictionary_base
title: dictionary_base table
description: Language catalog for the ejournal dictionaries (automatic proof reading of message text etc)
so.generated: true
keywords: database table dictionary_base
so.topic: reference
so.envir: onsite, online
---

# dictionary\_base Table (359)

Language catalog for the ejournal dictionaries (automatic proof reading of message text etc)

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

## Relationships

| Table|  Description |
|------|-------------|
|[dictionary](dictionary.md)  |User added dictionary words |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

