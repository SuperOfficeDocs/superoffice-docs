---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# DbiTaskFailed (301)

Called when a DBI task fails to execute successfully.

## Input values
|Variable|Description|
|---|---|
| `entryId` | the dbi agent schedule ID|

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("entryId");
```
