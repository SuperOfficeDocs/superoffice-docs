---
title: triggerscripts
description: Trigger scripts
so.author: Michel Krohn-Dale
so.date: 17.08.2021
keywords:
---

# SalesBeforeSaveProjectMember (1011)

Called before projectmember is saved. EventData contains all variables passed by datahandler in Sales client.

## Input values

[!include[Relation input values](includes/projectmember-var.md)]

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
