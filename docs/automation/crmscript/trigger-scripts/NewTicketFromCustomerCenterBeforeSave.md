---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# NewTicketFromCustomerCenterBeforeSave (103)

## Input values

* `customerId` = person ID

Output values:

* `errorMessage`

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("customerId");
```
