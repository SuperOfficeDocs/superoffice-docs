---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# TicketChangedOwnedBy (142)

Runs when a ticket is saved and the owner changed.

## Input values

* `entryId` = request ID
* `ticketId` = request ID
* `personId` = customer (person) ID
* `contactId` = company (contact) ID
* `owned_by.old` = old value
* `owned_by.new` = new value

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("ticketId");
```
