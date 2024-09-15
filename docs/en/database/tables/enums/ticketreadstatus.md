---
uid: enum-ticketreadstatus
title: Enum values for TicketReadStatus
description: Lists the enum values for TicketReadStatus.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# TicketReadStatus Enum

Whether the owner has read the ticket or not (red, yellow, green).

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Unknown status|
|Green|1|The ticket has been read by the owner|
|Yellow|2|The ticket has received new information since last read|
|Red|3|The ticket is unread by the owner|

## Usage

* [ticket](../ticket.md).read_status - This table contains the tickets (requests) of the system. Its purpose should be evident.
