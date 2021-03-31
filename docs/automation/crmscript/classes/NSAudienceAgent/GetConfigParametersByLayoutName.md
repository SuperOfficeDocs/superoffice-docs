---
title: crmscript_ref_NSAudienceAgent_GetConfigParametersByLayoutName
description: AudienceConfigParameterArray GetConfigParametersByLayoutName(String layoutName)
intellisense: NSAudienceAgent.GetConfigParametersByLayoutName
keywords: NSAudienceAgent,GetConfigParametersByLayoutName
so.topic: reference
---

Gets the Audience configuration parameters belonging to a given Audience layout.

**Parameters:**
 - **layoutName** Name of the Audience layout instance

**Returns:** Array of Audience configuration parameters.

```crmscript
NSAudienceAgent agent;
String layoutName;
AudienceConfigParameterArray res = agent.GetConfigParametersByLayoutName(layoutName);
```

