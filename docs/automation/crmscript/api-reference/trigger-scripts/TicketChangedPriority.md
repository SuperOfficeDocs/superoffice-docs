---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# TicketChangedPriority (140)

Runs when a ticket is saved and priority changed.

## Input values
|Variable|Description|
|---|---|
| `entryId` | request ID|
| `ticketId` | request ID|
| `personId` | customer (person) ID|
| `contactId` | company (contact) ID|
| `priority.old` | old value|
| `priority.new` | new value|

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("ticketId");
```
