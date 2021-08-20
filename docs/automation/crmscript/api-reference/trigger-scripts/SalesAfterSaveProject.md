---
title: triggerscripts
description: Trigger scripts
so.author: Michel Krohn-Dale
so.date: 17.08.2021
keywords:
---

# SalesAfterSaveProject (1109)

Called after a project is saved. EventData contains all variables passed by datahandler in Sales client.

## Input values

[!include[ProjectEntity input values](includes/project-var.md)]

## Sample code

```crmscript
// Get the variables in the current context
EventData ed = getEventData();


```
