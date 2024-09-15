---
uid: table-ejsel_result_set
title: ejsel_result_set table
description: This table stores result set reference data, result sets for selections
so.generated: true
keywords: database table ejsel_result_set
so.topic: reference
so.envir: onsite, online
---

# ejsel\_result\_set Table (398)

This table stores result set reference data, result sets for selections

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|meta\_result|The id of the selection for which this item is part of a result|FK [ejsel_meta_result](ejsel-meta-result.md)| |
|ref\_id|The id of the element for which this item belongs|Int| |


![ejsel_result_set table relationship diagram](./media/ejsel_result_set.png)

[!include[details](./includes/ejsel-result-set.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|meta\_result |FK |Index |
|ref\_id |Int |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[ejsel\_meta\_result](ejsel-meta-result.md)  |This table stores result meta data |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

