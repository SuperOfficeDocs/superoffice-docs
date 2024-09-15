---
uid: enum-ticketprioritystatus
title: Enum values for TicketPriorityStatus
description: Lists the enum values for TicketPriorityStatus.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# TicketPriorityStatus Enum

The status (normal/deleted) of the priority.

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|The status is unknown, should normally not occure in the database|
|Normal|1|The status is normal|
|Deleted|2|The status is marked as deleted|

## Usage

* [ticket_priority](../ticket-priority.md).status - This table contains the ticket priorities.
