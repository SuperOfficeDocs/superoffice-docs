---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# NewTicket (100)

Runs when a new ticket is created.

## Input values

* `entryId` = request ID
* `ticketId` = request ID
* `personId` = customer (person) ID
* `contactId` = company (contact) ID

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("customerId");
```
