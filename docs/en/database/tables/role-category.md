---
uid: table-role_category
title: role_category table
description: Category membership associated with a role
so.generated: true
keywords: database table role_category
so.topic: reference
so.envir: onsite, online
---

# role\_category Table (325)

Category membership associated with a role

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|role|The id of the group. Deprecated.|FK [ej_role](ej-role.md)| |
|category|The id of the category.|FK [ej_category](ej-category.md)| |
|crm\_role|Link to Role|FK [Role](role.md)|&#x25CF;|


![role_category table relationship diagram](./media/role_category.png)

[!include[details](./includes/role-category.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|role |FK |Index |
|category |FK |Index |
|crm\_role |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[ej\_category](ej-category.md)  |This table contains categories, in which tickets are categorized. The categories are organized in a hierarchial manner. |
|[ej\_role](ej-role.md)  |Define access rights, memberships and other properties for role user members |
|[Role](role.md)  |User roles for role-based security, names and tooltips are in LocaleText. For more information regarding role based security, see http://techdoc.superoffice.com |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

