---
uid: table-ticket_customers
title: ticket_customers table
description: This table allows several customers to be connected to several tickets (many-to-many)
so.generated: true
keywords: database table ticket_customers
so.topic: reference
so.envir: onsite, online
---

# ticket\_customers Table (264)

This table allows several customers to be connected to several tickets (many-to-many)

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|ticket\_id|Reference to a ticket|FK [ticket](ticket.md)| |
|customer\_id|Reference to a customer|FK [person](person.md)| |


![ticket_customers table relationship diagram](./media/ticket_customers.png)

[!include[details](./includes/ticket-customers.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|ticket\_id |FK |Index |
|customer\_id |FK |Index |
|ticket\_id, customer\_id |FK, FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[person](person.md)  |Persons in a company or an organizations. All associates have a corresponding person record |
|[ticket](ticket.md)  |This table contains the tickets (requests) of the system. Its purpose should be evident. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

