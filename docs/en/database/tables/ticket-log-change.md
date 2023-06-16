---
uid: table-ticket_log_change
title: ticket_log_change table
description: This table contains log entries for the tickets.
so.generated: true
keywords: database table ticket_log_change
so.topic: reference
so.envir: onsite, online
---

# ticket\_log\_change Table (268)

This table contains log entries for the tickets.

## Fields

| Name | Description | Type | Null |
|------|-------------|------|:----:|
|id|The primary key (auto-incremented)|PK| |
|ticket\_id|The id of the ticket this entry is connected to.|FK [ticket](ticket.md)| |
|message\_id|If this entry is connected to a message, then this is a message change log entry.|FK [ej_message](ej-message.md)| |
|action\_id|The id of ticket_log_action this entry is connected to.|FK [ticket_log_action](ticket-log-action.md)| |
|extra\_field\_id|The id of the extra_field this entry is connected to.|FK [extra_fields](extra-fields.md)| |
|log\_change|An enum indicating what kind of log-entry this is.|Int|&#x25CF;|
|to\_value|A the &amp;apos;to&amp;apos; value|String(255)| |
|from\_value|A the &amp;apos;from&amp;apos; value|String(255)| |


![ticket_log_change table relationship diagram](./media/ticket_log_change.png)

[!include[details](./includes/ticket-log-change.md)]

## Indexes

| Fields | Types | Description |
|--------|-------|-------------|
|id |PK |Clustered, Unique |
|ticket\_id |FK |Index |
|message\_id |FK |Index |
|action\_id |FK |Index |
|extra\_field\_id |FK |Index |

## Relationships

| Table|  Description |
|------|-------------|
|[ej\_message](ej-message.md)  |This table contains the messages listed under tickets. |
|[extra\_fields](extra-fields.md)  |This table contains entries for the extra fields in the system. |
|[ticket](ticket.md)  |This table contains the tickets (requests) of the system. Its purpose should be evident. |
|[ticket\_log\_action](ticket-log-action.md)  |This table contains actions for the tickets. |


## Replication Flags

* None

## Security Flags

* No access control via user's Role.

