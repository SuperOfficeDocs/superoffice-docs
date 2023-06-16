---
uid: table-ticket_log
title: ticket_log table
description: This table contains log entries for the tickets.
so.generated: true
keywords: database table ticket_log
so.topic: reference
so.envir: onsite, online
---

# ticket\_log Table (267)

This table contains log entries for the tickets.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|ticket\_id|The id of the ticket this entry is connected to.|FK [ticket](ticket.md)| |
|log\_code|An enum indicating what kind of log-entry this is.|log_code|&#x25CF;|
|log\_who|The username/alias of the user performing the action.|String(255)|&#x25CF;|
|log\_when|When the action occured.|DateTime|&#x25CF;|
|log\_description|A string describing the event (or part of such) to be logged.|Clob|&#x25CF;|
|log\_what\_value2|A reference to various tables, depending on the log_code.|Int|&#x25CF;|


![ticket_log table relationship diagram](./media/ticket_log.png)

[!include[details](./includes/ticket-log.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|ticket\_id |FK |Index |
|log\_code |Enum |Index |
|log\_when |DateTime |Index |
|log\_what\_value2 |Int |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[ticket](ticket.md)  |This table contains the tickets (requests) of the system. Its purpose should be evident. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

