---
uid: table-s_list_customer
title: s_list_customer table
description: Elements in a customer list.
so.generated: true
keywords: database table s_list_customer
so.topic: reference
so.envir: onsite, online
---

# s\_list\_customer Table (346)

Elements in a customer list.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|list\_id|Which list this element belongs to|FK [s_list](s-list.md)| |
|customer\_id||FK [person](person.md)| |


![s_list_customer table relationship diagram](./media/s_list_customer.png)

[!include[details](./includes/s-list-customer.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|list\_id |FK |Index |
|customer\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[person](person.md)  |Persons in a company or an organizations. All associates have a corresponding person record |
|[s\_list](s-list.md)  |A list, dynamic or static |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

