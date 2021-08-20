---
title: triggerscripts
description: Trigger scripts
so.author: Michel Krohn-Dale
so.date: 17.08.2021
keywords:
---

# SalesBeforeSaveQuoteLine (1013)

Called before an quote line is saved. EventData contains all variables passed by datahandler in Sales client.

## Input values

[!include[Quote line input values](includes/quoteline-var.md)]

## Sample code

```crmscript
#setLanguageLevel 3;
EventData ed = getEventData();
String param1 = ed.getInputValue("QuoteLine.QuoteLineId");
```
