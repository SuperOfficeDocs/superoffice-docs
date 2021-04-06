---
uid: crmscript_ref_NSConfigurationAgent_SaveWindowPosSizes
title: WindowPosSizeArray SaveWindowPosSizes(WindowPosSizeArray windowPosSizes)
intellisense: NSConfigurationAgent.SaveWindowPosSizes
keywords: NSConfigurationAgent, SaveWindowPosSizes
so.topic: reference
---

Saves a set of window and dialog position and size settings.

**Parameters:**
 - **windowPosSizes** The items that are saved

**Returns:** The saved items

```crmscript
NSConfigurationAgent agent;
WindowPosSizeArray windowPosSizes;
WindowPosSizeArray res = agent.SaveWindowPosSizes(windowPosSizes);
```

