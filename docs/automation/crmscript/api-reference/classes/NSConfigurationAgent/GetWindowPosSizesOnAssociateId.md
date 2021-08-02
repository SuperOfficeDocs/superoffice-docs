---
uid: crmscript_ref_NSConfigurationAgent_GetWindowPosSizesOnAssociateId
title: NSWindowPosSize[] GetWindowPosSizesOnAssociateId(Integer associateId)
intellisense: NSConfigurationAgent.GetWindowPosSizesOnAssociateId
keywords: NSConfigurationAgent, GetWindowPosSizesOnAssociateId
so.topic: reference
---

Gets the window and dialog position and size settings belonging to the specified associate

**Parameters:**
 - **associateId** Associate id of the Associate/Person owning these window settings

**Returns:** NSWindowPosSize[]

```crmscript
NSConfigurationAgent agent;
Integer associateId;
NSWindowPosSize[] res = agent.GetWindowPosSizesOnAssociateId(associateId);
```

