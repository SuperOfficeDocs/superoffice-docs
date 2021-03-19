---
uid: static_list_ref
title: static_list_ref table
description: This table stores id references for selections id lists
so.generated: true
keywords:
  - "database"
  - "static_list_ref"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# StaticListRef Table (396)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|ref\_id|The id of the element which this item points to|Int| |
|list\_id|The id of the list we link to|Int| |


![static_list_ref table relationship diagram](media\static_list_ref.png)

[!include[details](./includes/static-list-ref.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|ref\_id |Int |Index |
|list\_id |Int |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

