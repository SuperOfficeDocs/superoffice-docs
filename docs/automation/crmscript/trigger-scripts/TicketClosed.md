---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# TicketClosed (110)

Runs when a ticket is saved and the status changes to closed.

## Input values

* `entryId` = request ID
* `ticketId` = request ID
* `personId` = customer (person) ID
* `contactId` = company (contact) ID
* `ticketStatus.old` = old value
* `ticketStatus.new` = new value

[!include[ALT](./includes/ticket-status.md)]

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("customerId");
```
