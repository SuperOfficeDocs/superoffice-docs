---
uid: table-s_dyn_criteria
title: s_dyn_criteria table
description: Contains criterias for a dynamic list.
so.generated: true
keywords:
  - "database"
  - "s_dyn_criteria"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# s\_dyn\_criteria Table (350)

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

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|list\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

