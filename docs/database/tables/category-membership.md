---
uid: table-category-membership
title: category\_membership table
description: This table connects users to categories (many-to-many).
so.generated: true
keywords:
  - "database"
  - "category_membership"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# category\_membership Table (270)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|category\_id|The reference to the category.|FK [ej-category](ej-category.md)| |
|user\_id|The reference to the ej user.|FK [ejuser](ejuser.md)| |
|weight|The proportion used for weighted delegation within category if weighted assignment is active. 0 = no automatic assignment, -1 = defined by usergroup via ejCategoryGroup, counts as 0 weight. |Short|&#x25CF;|


![category_membership table relationship diagram](./media/category_membership.png)

[!include[details](./includes/category-membership.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|category\_id |FK |Index |
|user\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

