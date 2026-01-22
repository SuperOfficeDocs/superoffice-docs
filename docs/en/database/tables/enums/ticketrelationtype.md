---
uid: enum-ticketrelationtype
title: Enum values for TicketRelationType
description: Lists the enum values for TicketRelationType.
generated: true
keywords: database enum
content_type: reference
envir: onsite, online
---

# TicketRelationType Enum

Type of the relation (Related, Parent, Child)

| Name | Value | Description |
|------|-------|-------------|
|Related|0|Tickets are related without a hierarchy|
|Parent|1|Destination is parent of the source Ticket in this relation|
|Child|2|Destination is child of the source Ticket in this relation|

## Usage

* [ticket_relation_def](../ticket-relation-def.md).relation_type - Ticket relation definition
