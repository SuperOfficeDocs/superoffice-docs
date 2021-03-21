---
uid: enum-ticketbasestatus
title: Enum values for TicketBaseStatus
description: Lists the enum values for TicketBaseStatus.
so.generated: true
keywords:
  - "database"
so.date: 21.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# TicketBaseStatus Enum

The &amp;apos;classic&amp;apos; ticket status. I.e. active/closed/postponed/deleted

* Unknown = 0
* Active = 1
* Closed = 2
* Postponed = 3
* Deleted = 4
* Merged = 5

## Usage

* [ticket](../ticket.md).status - This table contains the tickets (requests) of the system. Its purpose should be evident.
* [ticket_status](../ticket-status.md).status - This table user defined ticket status values.
