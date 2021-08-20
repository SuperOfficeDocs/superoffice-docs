---
title: triggerscripts
description: Trigger scripts
so.author: Christian Mogensen
so.date: 11.11.2020
keywords:
---

# ScheduledTaskFailed (300)

Runs after scheduled task failed

## Input values
|Variable|Description|
|---|---|
| `entryId` | scheduled task ID|
| `retries` | schedule number of retries|
| `disabled` | schedule disabled ?|
| `errorMessage` | error message string|
| `nextExecution` | next scheduled start (datetime)|
| `executionTime` | int|
| `scriptId` | script ID to execute|
| `scriptName` | name of script|
| `scriptIncludeId` | unique ID of script|

## Sample code

```crmscript
#setLanguageLevel 3;
String param1 = getVariable("entryId");
```
