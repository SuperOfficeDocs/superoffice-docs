---
uid: enum-ticketbasestatus
title: Enum values for TicketBaseStatus
description: Lists the enum values for TicketBaseStatus.
so.generated: true
keywords:
  - "database"
so.date: 22.03.2021
so.topic: reference
so.envir:
  - "onsite"
  - "online"
---

# TicketBaseStatus Enum

The &amp;apos;classic&amp;apos; ticket status. I.e. active/closed/postponed/deleted

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Unknown / uninitialized|
|Active|1|Request is currently active|
|Closed|2|Request has been closed|
|Postponed|3|Request has been postponed|
|Deleted|4|Request has been deleted|
|Merged|5|Request has been merged with another request|

## Usage

* [ticket](../ticket.md).status - This table contains the tickets (requests) of the system. Its purpose should be evident.
* [ticket_status](../ticket-status.md).status - This table user defined ticket status values.
