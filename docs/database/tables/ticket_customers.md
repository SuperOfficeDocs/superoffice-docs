---
uid: ticket_customers
title: ticket_customers table
description: This table allows several customers to be connected to several tickets (many-to-many)
so.generated: true
keywords:
  - "database"
  - "ticket_customers"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# TicketCustomers Table (264)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|ticket\_id|Reference to a ticket|FK [ticket](ticket.md)| |
|customer\_id|Reference to a customer|FK [person](person.md)| |


![ticket_customers table relationship diagram](media\ticket_customers.png)

[!include[details](./includes/ticket-customers.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|ticket\_id |FK |Index |
|customer\_id |FK |Index |
|ticket\_id, customer\_id |FK, FK |Index |

## Replication Flags

* None

## Security Flags

* No access control via user's Role.

