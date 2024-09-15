---
uid: table-dictionary
title: dictionary table
description: User added dictionary words
so.generated: true
keywords: database table dictionary
so.topic: reference
so.envir: onsite, online
---

# dictionary Table (358)

User added dictionary words

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|base\_id|The reference to the dictionary base.|FK [dictionary_base](dictionary-base.md)| |
|user\_id|The reference to the user.|FK [ejuser](ejuser.md)| |
|include|Include/Exclude word.|Int| |
|word|User word|String(32)| |


![dictionary table relationship diagram](./media/dictionary.png)

[!include[details](./includes/dictionary.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|base\_id |FK |Index |
|user\_id |FK |Index |
|include |Int |Index |
|word |String(32) |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[dictionary\_base](dictionary-base.md)  |Language catalog for the ejournal dictionaries (automatic proof reading of message text etc) |
|[ejuser](ejuser.md)  |This table contains entries for the users of the system. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

