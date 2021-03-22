---
uid: table-form-keys
title: form\_keys table
description: Keys that makes sure a form is not posted twice
so.generated: true
keywords:
  - "database"
  - "form_keys"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# form\_keys Table (366)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|form\_key|A random key|String(40)| |
|time\_of\_entry|When the key was generated|DateTime|&#x25CF;|


![form_keys table relationship diagram](./media/form_keys.png)

[!include[details](./includes/form-keys.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|form\_key |String(40) |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

