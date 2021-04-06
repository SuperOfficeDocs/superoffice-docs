---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# TicketActivated (113)

Runs when ticket is saved and status changed from postponed to active.

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
String param1 = getVariable("ticketId");
```
