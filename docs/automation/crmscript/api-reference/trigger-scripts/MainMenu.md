---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# MainMenu (113)

Runs when the main menu is rendered

## Sample code

```crmscript
#setLanguageLevel 3;
MainMenu menu = getMainMenu();
menu.addItem("List equipment", getProgram(1) + "&action=listExtraTable&extraTable=y_equipment");
```
