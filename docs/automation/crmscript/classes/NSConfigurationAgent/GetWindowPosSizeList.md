---
uid: crmscript_ref_NSConfigurationAgent_GetWindowPosSizeList
title: NSWindowPosSize[] GetWindowPosSizeList(Integer[]  windowPosSizeIds);
intellisense: NSConfigurationAgent.GetWindowPosSizeList
keywords: NSConfigurationAgent, GetWindowPosSizeList
so.topic: reference
---

Gets a vector of WindowPosSize objects.

**Parameters:**
 - **windowPosSizeIds** The identifiers of the NSWindowPosSize objects

**Returns:** Vector of NSWindowPosSize objects

```crmscript
Integer[] ids;
NSConfigurationAgent agent;
agent.GetWindowPosSizeList(ids);
```

