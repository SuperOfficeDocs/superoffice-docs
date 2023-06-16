---
uid: table-sms_hysteria
title: sms_hysteria table
description: Avoid sending too many sms messages in a short time interval to one person
so.generated: true
keywords: database table sms_hysteria
so.topic: reference
so.envir: onsite, online
---

# sms\_hysteria Table (367)

Avoid sending too many sms messages in a short time interval to one person

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|recipient\_address||String(255)|&#x25CF;|
|created\_at||DateTime|&#x25CF;|


![sms_hysteria table relationship diagram](./media/sms_hysteria.png)

[!include[details](./includes/sms-hysteria.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

