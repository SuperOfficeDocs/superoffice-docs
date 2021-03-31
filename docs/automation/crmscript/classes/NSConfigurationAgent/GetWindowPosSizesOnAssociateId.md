---
title: crmscript_ref_NSConfigurationAgent_GetWindowPosSizesOnAssociateId
description: WindowPosSizeArray GetWindowPosSizesOnAssociateId(Integer associateId)
intellisense: NSConfigurationAgent.GetWindowPosSizesOnAssociateId
keywords: NSConfigurationAgent,GetWindowPosSizesOnAssociateId
so.topic: reference
---

Gets the window and dialog position and size settings belonging to the specified associate

**Parameters:**
 - **associateId** Associate id of the Associate/Person owning these window settings

**Returns:** Array of window and dialog position and size settings

```crmscript
NSConfigurationAgent agent;
Integer associateId;
WindowPosSizeArray res = agent.GetWindowPosSizesOnAssociateId(associateId);
```

