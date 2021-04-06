---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# NewTicketFromForm (106)

Called when a form submission creates a new ticket.

## Input values

* `entryId` = the new ticket ID
* `ticketId` = the new ticket ID
* `categoryId` = the new ticket category ID
* `title` = the new ticket title
* `message` = the new ticket body text

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("entryId");
```
