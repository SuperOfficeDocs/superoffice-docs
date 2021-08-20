---
title: triggerscripts
description: Trigger scripts
so.author: Michel Krohn-Dale
so.date: 17.08.2021
keywords:
---

# SalesBeforeSavePerson (1006)

Called before a person is saved. EventData contains all variables passed by datahandler in Sales client.

## Input values

[!include[PersonEntity input values](includes/person-var.md)]

## Sample code

```crmscript
#setLanguageLevel 3;
EventData ed = getEventData();
String param1 = ed.getInputValue("PersonEntity.PersonId");
```
