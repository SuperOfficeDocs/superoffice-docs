---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# TicketSave (109)

Called when a ticket is being saved.

## Input values

* `ticketId` = the ticket ID
* `activeUser` = the ejUser ID

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("ticketId");
```
