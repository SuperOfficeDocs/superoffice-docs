---
uid: table-s_dyn_criteria
title: s_dyn_criteria table
description: Contains criterias for a dynamic list.
so.generated: true
keywords: database table s_dyn_criteria
so.topic: reference
so.envir: onsite, online
---

# s\_dyn\_criteria Table (350)

Contains criterias for a dynamic list.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|list\_id|Connects the criteria to a list.|FK [s_list](s-list.md)| |
|sort\_order|The order to sort the query. Not really relevant|Int| |
|field|Which field to test in this criteria|String(64)| |
|operator|Equals, gt, lt etc.|operator| |
|value|The value|String(64)| |
|log\_op|And/or|log_op|&#x25CF;|


![s_dyn_criteria table relationship diagram](./media/s_dyn_criteria.png)

[!include[details](./includes/s-dyn-criteria.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|list\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[s\_list](s-list.md)  |A list, dynamic or static |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

