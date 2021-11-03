---
uid: table-s_list_customer
title: s_list_customer table
description: Elements in a customer list.
so.generated: true
keywords:
  - "database"
  - "s_list_customer"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# s\_list\_customer Table (346)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|list\_id|Which list this element belongs to|FK [s_list](s-list.md)| |
|customer\_id||FK [person](person.md)| |


![s_list_customer table relationship diagram](./media/s_list_customer.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|list\_id |FK |Index |
|customer\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

