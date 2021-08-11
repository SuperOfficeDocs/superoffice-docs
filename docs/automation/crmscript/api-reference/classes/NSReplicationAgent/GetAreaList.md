---
uid: crmscript_class_nsreplicationagent_getarealist
title: NSArea[] GetAreaList()
description: CRMScript method in the NSReplicationAgent class that gets an array of NSArea objects
intellisense: NSReplicationAgent.GetAreaList
keywords: NSReplicationAgent, GetAreaList, GetAreaList(Integer[])
so.topic: reference
---

# GetAreaList()

Gets an array of NSArea objects.

`NSArea[] GetAreaList(Integer[] areaIds)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| areaIds | Integer[] | The identifiers of the NSArea objects |

## Examples

```crmscript
Integer[] ids;
NSReplicationAgent agent;
agent.GetAreaList(ids);
```
