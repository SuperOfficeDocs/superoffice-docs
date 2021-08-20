---
title: triggerscripts
description: Trigger scripts
so.author: Michel Krohn-Dale
so.date: 17.08.2021
keywords:
---

# SalesBeforeSaveQuote (1003)

Called before an quote is saved. EventData contains all variables passed by datahandler in Sales client.

## Input values

[!include[Quote input values](includes/quote-var.md)]

## Sample code

```crmscript
#setLanguageLevel 3;
EventData ed = getEventData();
String param1 = ed.getInputValue("Quote.SaleId");
```
