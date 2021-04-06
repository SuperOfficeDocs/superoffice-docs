---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# TicketExternalMessageAdded (152)

Called for all external messages added to a ticket, following a call to the `TicketMessageAdded` trigger.

## Input values

* `entryId` = the ticket ID
* `ticketId` = the ticket ID
* `messageId` = the ticket message ID

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("entryId");
```
