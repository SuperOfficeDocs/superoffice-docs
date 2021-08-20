---
title: triggerscripts
description: Trigger scripts
so.author: Michel Krohn-Dale
so.date: 17.08.2021
keywords:
---

# SalesBeforeSaveSale (1008)

Called before a sale is saved. EventData contains all variables passed by datahandler in Sales client.

## Input values

[!include[SaleEntity input values](includes/sale-var.md)]

## Sample code

```crmscript
// Get the variables in the current context
EventData ed = getEventData();


```
