---
title: triggerscripts
description: Trigger scripts
so.author: Michel Krohn-Dale
so.date: 06.08.2021
keywords:
---

# ServiceScreenAddMessageBeforeSubmit (603)

Called before screen is submitted and values are saved, useful for validations with blocking of save.
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
String param1 = getVariable("button");
```
