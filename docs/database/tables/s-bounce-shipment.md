---
uid: table-s-bounce-shipment
title: s\_bounce\_shipment table
description: Email bounces from customers
so.generated: true
keywords:
  - "database"
  - "s_bounce_shipment"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# s\_bounce\_shipment Table (342)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|shipment\_id|The shipment this bounce belongs to|FK [s-shipment](s-shipment.md)| |
|customer\_id|The customer this bounce came from|FK [person](person.md)| |
|email|The email address for this particular bounce|String(255)|&#x25CF;|


![s_bounce_shipment table relationship diagram](./media/s_bounce_shipment.png)

[!include[details](./includes/s-bounce-shipment.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|shipment\_id |FK |Index |
|customer\_id |FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

