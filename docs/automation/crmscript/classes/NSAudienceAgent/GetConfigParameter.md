---
title: crmscript_ref_NSAudienceAgent_GetConfigParameter
description: AudienceConfigParameter GetConfigParameter(String layoutName, String parameterName)
intellisense: NSAudienceAgent.GetConfigParameter
keywords: NSAudienceAgent,GetConfigParameter
so.topic: reference
---

Gets an Audience configuration parameter belonging to a given Audience layout with the specified configuration parameter name

**Parameters:**
 - **layoutName** Name of the Audience layout instance
 - **parameterName** The name of the Audience configuration parameter

**Returns:** The Audience configuration parameter.

```crmscript
NSAudienceAgent agent;
String layoutName;
String parameterName;
AudienceConfigParameter res = agent.GetConfigParameter(layoutName, parameterName);
```

