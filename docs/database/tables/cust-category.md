---
uid: table-cust-category
title: cust\_category table
description: This table contains entries for categories exposed through a customer language.
so.generated: true
keywords:
  - "database"
  - "cust_category"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# cust\_category Table (321)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|name|The external name for this category.|String(255)|&#x25CF;|
|language\_id|The reference to the associated customer language.|FK [cust-lang](cust-lang.md)|&#x25CF;|
|category\_id|The reference to the associated category.|FK [ej-category](ej-category.md)|&#x25CF;|
|parent\_id|The parent category for this cust_category. -1 if this is a toplevel cust_category.|FK [cust-category](cust-category.md)|&#x25CF;|
|fullname|The fullname (compiled from parents&amp;apos; names) for this category. E.g. &amp;apos;norway/product A/support&amp;apos;.|String(255)|&#x25CF;|


![cust_category table relationship diagram](./media/cust_category.png)

[!include[details](./includes/cust-category.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|language\_id |FK |Index |
|category\_id |FK |Index |
|parent\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

