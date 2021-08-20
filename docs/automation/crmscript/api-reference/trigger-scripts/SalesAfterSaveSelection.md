---
title: triggerscripts
description: Trigger scripts
so.author: Michel Krohn-Dale
so.date: 17.08.2021
keywords:
---

# SalesAfterSaveSelection (1110)

Called after selection is saved. EventData contains all variables passed by datahandler in Sales client.

## Input values

[!include[Selection input values](includes/selection-var.md)]

## Sample code

```crmscript
#setLanguageLevel 3;
EventData ed = getEventData();

```
