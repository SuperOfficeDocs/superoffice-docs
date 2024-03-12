---
uid: table-ConfigurableScreenAppliesTo
title: ConfigurableScreenAppliesTo table
description: Mapping between recipes in scil and chosen type of data (appliesToKey) to differ layouts on
so.generated: true
keywords: database table ConfigurableScreenAppliesTo
so.topic: reference
so.envir: onsite, online
---

# ConfigurableScreenAppliesTo Table (465)

Mapping between recipes in scil and chosen type of data (appliesToKey) to differ layouts on

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|configurablescreenappliesto\_id|Primary key|PK| |
|recipeId|The recipe in scil that might be modified|String(255)|&#x25CF;|
|appliesToKey|Which data will be used to differ on layouts for this recipe|String(255)|&#x25CF;|
|registered|Registered when|UtcDateTime| |
|registered\_associate\_id|Registered by whom|FK [associate](associate.md)| |
|updated|Last updated when|UtcDateTime| |
|updated\_associate\_id|Last updated by whom|FK [associate](associate.md)| |
|updatedCount|Number of updates made to this record|UShort| |


![ConfigurableScreenAppliesTo table relationship diagram](./media/ConfigurableScreenAppliesTo.png)

[!include[details](./includes/configurablescreenappliesto.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|configurablescreenappliesto\_id |PK |Clustered, Unique |

## Relationships

| Table|  Description |
|------|-------------|
|[associate](associate.md)  |Employees, resources and other users - except for External persons |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

