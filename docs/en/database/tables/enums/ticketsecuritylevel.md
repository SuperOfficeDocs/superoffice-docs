---
uid: enum-ticketsecuritylevel
title: Enum values for TicketSecurityLevel
description: Lists the enum values for TicketSecurityLevel.
so.generated: true
keywords: database enum
so.topic: reference
so.envir: onsite, online
---

# TicketSecurityLevel Enum

The securitylevel of the ticket.

| Name | Value | Description |
|------|-------|-------------|
|Unknown|0|Unknown level|
|Internal|1|Internal tickets will not be shown on the Customer Centre|
|External|2|External tickets will be shown on the Customer Centre|

## Usage

* [ej_message](../ej-message.md).slevel - This table contains the messages listed under tickets.
* [ticket](../ticket.md).slevel - This table contains the tickets (requests) of the system. Its purpose should be evident.
