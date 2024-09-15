---
uid: table-registry
title: registry table
description: System settings
so.generated: true
keywords: database table registry
so.topic: reference
so.envir: onsite, online
---

# registry Table (253)

System settings

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|reg\_id|The enum used as identificator|Int| |
|name|A descriptive string for the entry|String(255)| |
|value|The value for the registry entry.|String(255)|&#x25CF;|


![registry table relationship diagram](./media/registry.png)

[!include[details](./includes/registry.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

