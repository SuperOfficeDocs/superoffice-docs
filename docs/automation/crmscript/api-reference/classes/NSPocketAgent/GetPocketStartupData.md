---
uid: crmscript_class_nspocketagent_getpocketstartupdata
title: NSPocketStartupData GetPocketStartupData()
intellisense: NSPocketAgent.GetPocketStartupData
keywords: NSPocketAgent, GetPocketStartupData, GetPocketStartupData(String[],DateTime)
so.topic: reference
---

# GetPocketStartupData()

Returns start-up data for SuperOffice Pocket CRM

`NSPocketStartupData GetPocketStartupData(String[] tables, DateTime currentClientTime)`

## Parameters

| tables | String[] | Tables to check for license |
| currentClientTime | Datetime | The current time on the client, used for overdue sale lookup having correct timezone relative to the client |

## Examples

```crmscript
NSPocketAgent agent;
String[] tables;
DateTime currentClientTime;
NSPocketStartupData res = agent.GetPocketStartupData(tables, currentClientTime);
```
