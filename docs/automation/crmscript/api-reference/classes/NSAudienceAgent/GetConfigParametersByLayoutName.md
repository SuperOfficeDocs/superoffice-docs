---
uid: crmscript_ref_NSAudienceAgent_GetConfigParametersByLayoutName
title: AudienceConfigParameter[] GetConfigParametersByLayoutName(String layoutName)
intellisense: NSAudienceAgent.GetConfigParametersByLayoutName
keywords: NSAudienceAgent, GetConfigParametersByLayoutName
so.topic: reference
---

Gets the Audience configuration parameters belonging to a given Audience layout.

**Parameters:**
 - **layoutName** Name of the Audience layout instance

**Returns:** Array of Audience configuration parameters.

```crmscript
NSAudienceAgent agent;
String layoutName;
AudienceConfigParameter[] res = agent.GetConfigParametersByLayoutName(layoutName);
```

