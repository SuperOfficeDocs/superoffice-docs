---
uid: table-category_membership
title: category_membership table
description: This table connects users to categories (many-to-many).
so.generated: true
keywords: database table category_membership
so.topic: reference
so.envir: onsite, online
---

# category\_membership Table (270)

This table connects users to categories (many-to-many).

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|category\_id|The reference to the category.|FK [ej_category](ej-category.md)| |
|user\_id|The reference to the ej user.|FK [ejuser](ejuser.md)| |
|weight|The proportion used for weighted delegation within category if weighted assignment is active. 0 = no automatic assignment.|Short|&#x25CF;|
|is\_defined\_by\_usergroup|Specifies if membership was defined by usergroup via ejCategoryGroup|Bool| |


![category_membership table relationship diagram](./media/category_membership.png)

[!include[details](./includes/category-membership.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|category\_id |FK |Index |
|user\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[ej\_category](ej-category.md)  |This table contains categories, in which tickets are categorized. The categories are organized in a hierarchial manner. |
|[ejuser](ejuser.md)  |This table contains entries for the users of the system. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

