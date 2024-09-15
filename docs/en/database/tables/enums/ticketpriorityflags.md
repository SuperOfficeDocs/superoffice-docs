---
uid: enum-ticketpriorityflags
title: Enum values for TicketPriorityFlags
description: Lists the enum values for TicketPriorityFlags.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# TicketPriorityFlags Enum

A bitmask of flags.

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|No flags set|
|External|1|The ticket priority will be avilable in the Customer Centre|
|Default|2|This is the ticket priority that should default be set in the UI when creating a request|
|AlertSchedule|4|Escalate requests according to time frame|

## Usage

* [ticket_priority](../ticket-priority.md).flags - This table contains the ticket priorities.
