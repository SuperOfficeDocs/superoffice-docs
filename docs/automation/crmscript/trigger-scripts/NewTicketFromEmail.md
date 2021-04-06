---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# NewTicketFromEmail (102)

Runs after `ImportMailAfterProcessing` (304) if ticket did not exist.

## Input values

* `messageId` = message ID (int)
* `entryId` = request ID
* `ticketId` = request ID
* `customerId` = person ID
* `customerEmail` = person email address
* `mailBackup` = backup string
* `filterId` = filter ID
* `to` = to header value
* `from` = from header value
* `isNewCustomer` = new customer? (0/1)

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("customerId");
```
