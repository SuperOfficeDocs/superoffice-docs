---
uid: table-EjCategoryGroupLink
title: EjCategoryGroupLink table
description: User group link table for EjCategory, for mass handling ej_category members
so.generated: true
keywords:
  - "database"
  - "EjCategoryGroupLink"
so.date: 11.02.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# EjCategoryGroupLink Table (450)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|ej\_categorygrouplink\_id|Primary key|PK| |
|ej\_category\_id|Link to EjCategory list table|FK [ej_category](ej-category.md)| |
|group\_id|Link to Group table|FK [UserGroup](usergroup.md)| |
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![EjCategoryGroupLink table relationship diagram](./media/EjCategoryGroupLink.png)

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|ej\_categorygrouplink\_id |PK |Clustered, Unique |
|ej\_category\_id |FK |Index |
|group\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

