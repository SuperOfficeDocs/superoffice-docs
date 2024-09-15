---
uid: table-TypicalSearch
title: TypicalSearch table
description: Owner of a set of predefined selection criteria
so.generated: true
keywords: database table TypicalSearch
so.topic: reference
so.envir: onsite, online
---

# TypicalSearch Table (494)

Owner of a set of predefined selection criteria

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|typicalsearch\_id|Primary key|PK| |
|Title|The title of the typical search (multilingual)|String(4000)|&#x25CF;|
|Tooltip|The tooltip for the typical search (multilingual)|String(4000)|&#x25CF;|
|EntityName|The name of the entity the typical search links to|String(255)|&#x25CF;|
|IsEntityDefault|Indicates if this is the default set of criteria for an entity|Bool|&#x25CF;|
|IncludePerson|For selection-of-company: state of the Include Main Contact checkbox|Bool|&#x25CF;|
|Source|Name of organisation that sources and maintains this TypicalSearch. Allows for both SuperOffice and partners to maintain sets of typical searches without conflict|String(255)|&#x25CF;|
|VersionNumber|The current downloaded version of this typical search|Int|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![TypicalSearch table relationship diagram](./media/TypicalSearch.png)

[!include[details](./includes/typicalsearch.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|typicalsearch\_id |PK |Clustered, Unique |
|EntityName, Source |String(255), String(255) |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

