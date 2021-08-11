---
uid: crmscript_ref_NSAudienceAgent_GetMyConfigParameter
title: NSAudienceConfigParameter GetMyConfigParameter(String parameterName)
intellisense: NSAudienceAgent.GetMyConfigParameter
keywords: NSAudienceAgent, GetMyConfigParameter
so.topic: reference
---

# NSAudienceConfigParameter GetMyConfigParameter(String parameterName)

Gets an Audience configuration parameter belonging to the currently logged on user with the specified configuration parameter name.

**Parameters:**
 - **parameterName** The name of the Audience configuration parameter

**Returns:** The Audience configuration parameter.

```crmscript
NSAudienceAgent agent;
String parameterName;
NSAudienceConfigParameter res = agent.GetMyConfigParameter(parameterName);
```

