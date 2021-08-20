---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# SalesAfterSaveStakeholder (1102)

Called after a sale stakeholder is saved. EventData contains all variables passed by datahandler in Sales client.

## Input values

[!include[Stakeholder input values](includes/stakeholder-var.md)]

## Sample code

```crmscript
#setLanguageLevel 3;
EventData ed = getEventData();
String[] param1 = ed.getInputValue("NewMembers").split("§");
for(Integer i = 0; i < param1.length(); i++)
{
//Do something with each new member
}
```
