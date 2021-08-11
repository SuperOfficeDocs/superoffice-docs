---
uid: crmscript_class_nsconfigurationagent_getwindowpossizelist
title: NSWindowPosSize[] GetWindowPosSizeList()
description: CRMScript method in the NSConfigurationAgent class that retrieves a list of NSWindowPosSize objects
intellisense: NSConfigurationAgent.GetWindowPosSizeList
keywords: NSConfigurationAgent, GetWindowPosSizeList, GetWindowPosSizeList(Integer[])
so.topic: reference
---

# GetWindowPosSizeList()

Returns an array of NSWindowPosSize objects.

`NSWindowPosSize[] GetWindowPosSizeList(Integer[] windowPosSizeIds)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| windowPosSizeIds | Integer[] | The IDs of the NSWindowPosSize objects to get |

## Examples

```crmscript
Integer[] ids;
NSConfigurationAgent agent;
agent.GetWindowPosSizeList(ids);
```
