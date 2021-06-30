---
uid: crmscript_ref_NSConfigurationAgent_SaveWindowPosSizes
title: WindowPosSize[] SaveWindowPosSizes(WindowPosSize[] windowPosSizes)
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
WindowPosSize[] windowPosSizes;
WindowPosSize[] res = agent.SaveWindowPosSizes(windowPosSizes);
```

