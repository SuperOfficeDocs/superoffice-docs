---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# SalesBeforeSaveStakeholder (1002)

Called before a sale stakeholder is saved.

## Input values

* `NewMembers` = "§" separated rows, each containing '|' separated columns: ID, contact ID, contact name, person ID, stakeholder role ID
* `ContactPersonList` = list of persons
* `CurrentContactName` = name string
* `CurrentContactId` = contact ID
* `CurrentEntityName` = sale
* `SelectedId` = highlighted ID
* `ExtraInfo`

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("ticketId");
```
