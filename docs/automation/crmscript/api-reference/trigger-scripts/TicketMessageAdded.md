---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# TicketMessageAdded (150)

Called for all messages added to a ticket, followed by call to either `TicketInternalMessageAdded` or `TicketExternalMessageAdded` trigger.

## Input values
|Variable|Description|
|---|---|
| `entryId` | the ticket ID|
| `ticketId` | the ticket ID|
| `messageId` | the ticket message ID|

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("entryId");
```
