---
uid: crmscript_ref_NSAudienceAgent_GetConfigParametersByLayoutName
title: NSAudienceConfigParameter[] GetConfigParametersByLayoutName(String layoutName)
intellisense: NSAudienceAgent.GetConfigParametersByLayoutName
keywords: NSAudienceAgent, GetConfigParametersByLayoutName
so.topic: reference
---

# NSAudienceConfigParameter[] GetConfigParametersByLayoutName(String layoutName)

Gets the Audience configuration parameters belonging to a given Audience layout.

**Parameters:**
 - **layoutName** Name of the Audience layout instance

**Returns:** Array of Audience configuration parameters.

```crmscript
NSAudienceAgent agent;
String layoutName;
NSAudienceConfigParameter[] res = agent.GetConfigParametersByLayoutName(layoutName);
```

