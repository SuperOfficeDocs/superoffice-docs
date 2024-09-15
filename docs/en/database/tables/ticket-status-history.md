---
uid: table-ticket_status_history
title: ticket_status_history table
description: This table contains the history of a tickets statuses. Each time a ticket changes status a copy of the previous status of the record will be saved 
so.generated: true
keywords: database table ticket_status_history
so.topic: reference
so.envir: onsite, online
---

# ticket\_status\_history Table (261)

This table contains the history of a tickets statuses. Each time a ticket changes status a copy of the previous status of the record will be saved 

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|ticket\_id|Reference to a ticket|FK [ticket](ticket.md)| |
|ticket\_status|User defined ticket status|FK [ticket_status](ticket-status.md)| |
|timespan|The time (seconds) the ticket was in that status. Calculated based on priority&amp;apos;s timeframe.|Int|&#x25CF;|
|real\_timespan|The time (seconds) the ticket was in that status. Not calculated based on priority&amp;apos;s timeframe.|Int|&#x25CF;|
|from\_datetime||DateTime|&#x25CF;|
|to\_datetime||DateTime|&#x25CF;|


![ticket_status_history table relationship diagram](./media/ticket_status_history.png)

[!include[details](./includes/ticket-status-history.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|ticket\_id |FK |Index |
|ticket\_status |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[ticket](ticket.md)  |This table contains the tickets (requests) of the system. Its purpose should be evident. |
|[ticket\_status](ticket-status.md)  |This table user defined ticket status values. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

