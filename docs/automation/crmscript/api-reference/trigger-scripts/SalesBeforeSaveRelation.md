---
title: triggerscripts
description: Trigger scripts
so.author: Michel Krohn-Dale
so.date: 17.08.2021
keywords:
---

# SalesBeforeSaveRelation (1007)

Called before a relation is saved. EventData contains all variables passed by datahandler in Sales client.

## Input values

[!include[Relation input values](includes/relations-var.md)]

## Sample code

```crmscript
#setLanguageLevel 3;
EventData ed = getEventData();
String param1 = ed.getInputValue("ContactRelationEntity.RelationId");
```
