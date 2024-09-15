---
uid: table-s_bounce_shipment
title: s_bounce_shipment table
description: Email bounces from customers
so.generated: true
keywords: database table s_bounce_shipment
so.topic: reference
so.envir: onsite, online
---

# s\_bounce\_shipment Table (342)

Email bounces from customers

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|Primary key|PK| |
|shipment\_id|The shipment this bounce belongs to|FK [s_shipment](s-shipment.md)| |
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

## Relationships

| Table|  Description |
|------|-------------|
|[person](person.md)  |Persons in a company or an organizations. All associates have a corresponding person record |
|[s\_shipment](s-shipment.md)  |Contains info about one shipment. The addresses are stored in s_shipment_addr |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

