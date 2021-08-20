---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# TicketChangedSlevel (145)

Runs when a ticket is saved and the security level changed.

## Input values
|Variable|Description|
|---|---|
| `entryId` | request ID|
| `ticketId` | request ID|
| `personId` | customer (person) ID|
| `contactId` | company (contact) ID|
| `slevel.old` | old value|
| `slevel.new` | new value|

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("ticketId");
```
