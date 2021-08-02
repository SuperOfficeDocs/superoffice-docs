---
uid: crmscript_ref_NSConfigurationAgent_GetWindowPosSizesOnPersonId
title: NSWindowPosSize[] GetWindowPosSizesOnPersonId(Integer personId)
intellisense: NSConfigurationAgent.GetWindowPosSizesOnPersonId
keywords: NSConfigurationAgent, GetWindowPosSizesOnPersonId
so.topic: reference
---

Gets the window and dialog position and size settings belonging to the specified person

**Parameters:**
 - **personId** Person id of the associate owning these window settings

**Returns:** NSWindowPosSize[]

```crmscript
NSConfigurationAgent agent;
Integer personId;
NSWindowPosSize[] res = agent.GetWindowPosSizesOnPersonId(personId);
```

