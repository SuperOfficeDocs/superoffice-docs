---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# NewNotifyTicketFromForm (105)

Called when a new ticket was created from a form.

## Input values

* `entryId` = the ticket ID
* `ticketId` = the ticket ID

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("entryId");
```
