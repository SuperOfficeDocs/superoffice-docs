---
uid: enum-ticketpriorityescalateevent
title: Enum values for TicketPriorityEscalateEvent
description: Lists the enum values for TicketPriorityEscalateEvent.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# TicketPriorityEscalateEvent Enum

This field indicates what to do with the escalation chain when a new request is registered

| Name | Value | Description |
|------|-------|-------------|
|None|-1|No esclate event set|
|Stop|0|This event will stop the escalation chain|
|Continue|1|Continue the escalation event from where it was previously stopped|
|Restart|2|Start the escalation chain over from the beginning|

## Usage

* [ticket_priority](../ticket-priority.md).ticket_read - This table contains the ticket priorities.
* [ticket_priority](../ticket-priority.md).changed_owner - This table contains the ticket priorities.
* [ticket_priority](../ticket-priority.md).ticket_newinfo - This table contains the ticket priorities.
* [ticket_priority](../ticket-priority.md).ticket_closed - This table contains the ticket priorities.
* [ticket_priority](../ticket-priority.md).ticket_changed_priority - This table contains the ticket priorities.
* [ticket_priority](../ticket-priority.md).ticket_new - This table contains the ticket priorities.
