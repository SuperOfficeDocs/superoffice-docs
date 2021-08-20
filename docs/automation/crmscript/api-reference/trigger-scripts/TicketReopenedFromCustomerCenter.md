---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# TicketReopenedFromCustomerCenter (121)

## Input values
|Variable|Description|
|---|---|
| `entryId` | ticket ID|
| `ticketId` | ticket ID|

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("ticketId");
```
