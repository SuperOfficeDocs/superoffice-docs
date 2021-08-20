---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# NewTicketFromCustomerCenterBeforeSave (103)

## Input values
|Variable|Description|
|---|---|
| `customerId` | person ID|

## Output values:
|Variable|Description|
|---|---|
| `errorMessage`||

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("customerId");
```
