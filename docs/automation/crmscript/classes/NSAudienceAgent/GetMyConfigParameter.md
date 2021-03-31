---
title: crmscript_ref_NSAudienceAgent_GetMyConfigParameter
description: AudienceConfigParameter GetMyConfigParameter(String parameterName)
intellisense: NSAudienceAgent.GetMyConfigParameter
keywords: NSAudienceAgent,GetMyConfigParameter
so.topic: reference
---

Gets an Audience configuration parameter belonging to the currently logged on user with the specified configuration parameter name.

**Parameters:**
 - **parameterName** The name of the Audience configuration parameter

**Returns:** The Audience configuration parameter.

```crmscript
NSAudienceAgent agent;
String parameterName;
AudienceConfigParameter res = agent.GetMyConfigParameter(parameterName);
```

