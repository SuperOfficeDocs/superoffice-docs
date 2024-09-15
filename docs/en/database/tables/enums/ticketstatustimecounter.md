---
uid: enum-ticketstatustimecounter
title: Enum values for TicketStatusTimeCounter
description: Lists the enum values for TicketStatusTimeCounter.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# TicketStatusTimeCounter Enum

Which field in ticket we count time spent on (queue, internal, external) 

| Name | Value | Description |
|------|-------|-------------|
|None|0|Not counted|
|Internally|1|Time is counted in the _internally field|
|Externally|2|Time is counted in the _externally field|
|Queue|3|Time is counted in the _queue field|

## Usage

* [ticket_status](../ticket-status.md).time_counter - This table user defined ticket status values.
