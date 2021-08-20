---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# ServiceScreenEditExtraTableLoad (510)

Called when screen is constructed, useful for setting default values into HTML elements
## Input values
|Variable|Description|
|---|---|
| `button` | HtmlSubmitButton element value|
| `x.value` | element x value|
| `x.displayValue` | element x display value|

All HTML elements in the screen are added to the input values.

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("customerId");
```
