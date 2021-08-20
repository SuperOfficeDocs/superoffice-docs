---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# TicketChangedCategory (141)

Runs when a ticket is saved and the ticket category changes ID.

## Input values
|Variable|Description|
|---|---|
| `entryId` | request ID|
| `ticketId` | request ID|
| `personId` | customer (person) ID|
| `contactId` | company (contact) ID|
| `category.old` | old value|
| `category.new` | new value|

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("personId");
```
