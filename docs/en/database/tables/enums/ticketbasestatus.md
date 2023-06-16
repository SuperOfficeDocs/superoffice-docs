---
uid: enum-ticketbasestatus
title: Enum values for TicketBaseStatus
description: Lists the enum values for TicketBaseStatus.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
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
|PostponedSpecific|1001|Should only be used for UI, when saved to DB it will be converted to Postponed|
|Postponed1Hour|1002|Should only be used for UI, when saved to DB it will be converted to Postponed|
|Postponed2Hours|1003|Should only be used for UI, when saved to DB it will be converted to Postponed|
|Postponed3Hours|1004|Should only be used for UI, when saved to DB it will be converted to Postponed|
|Postponed4Hours|1005|Should only be used for UI, when saved to DB it will be converted to Postponed|
|PostponedDay|1006|Should only be used for UI, when saved to DB it will be converted to Postponed|
|PostponedWeek|1007|Should only be used for UI, when saved to DB it will be converted to Postponed|
|PostponedMonth|1008|Should only be used for UI, when saved to DB it will be converted to Postponed|

## Usage

* [ticket](../ticket.md).status - This table contains the tickets (requests) of the system. Its purpose should be evident.
* [ticket_status](../ticket-status.md).status - This table user defined ticket status values.
