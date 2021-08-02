---
uid: crmscript_ref_NSConfigurationAgent_SaveWindowPosSizes
title: NSWindowPosSize[] SaveWindowPosSizes(NSWindowPosSize[] windowPosSizes)
intellisense: NSConfigurationAgent.SaveWindowPosSizes
keywords: NSConfigurationAgent, SaveWindowPosSizes
so.topic: reference
---

Saves a set of window and dialog position and size settings.

**Parameters:**
 - **windowPosSizes** The items that are saved

**Returns:** NSWindowPosSize[]

```crmscript
NSConfigurationAgent agent;
NSWindowPosSize[] windowPosSizes;
NSWindowPosSize[] res = agent.SaveWindowPosSizes(windowPosSizes);
```

