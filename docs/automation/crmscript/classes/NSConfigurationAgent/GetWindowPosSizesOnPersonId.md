---
uid: crmscript_ref_NSConfigurationAgent_GetWindowPosSizesOnPersonId
title: WindowPosSizeArray GetWindowPosSizesOnPersonId(Integer personId)
intellisense: NSConfigurationAgent.GetWindowPosSizesOnPersonId
keywords: NSConfigurationAgent, GetWindowPosSizesOnPersonId
so.topic: reference
---

Gets the window and dialog position and size settings belonging to the specified person

**Parameters:**
 - **personId** Person id of the associate owning these window settings

**Returns:** Array of window and dialog position and size settings

```crmscript
NSConfigurationAgent agent;
Integer personId;
WindowPosSizeArray res = agent.GetWindowPosSizesOnPersonId(personId);
```

