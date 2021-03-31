---
title: crmscript_ref_NSAudienceAgent_GetMyConfigParameterValue
description: String GetMyConfigParameterValue(String parameterName)
intellisense: NSAudienceAgent.GetMyConfigParameterValue
keywords: NSAudienceAgent,GetMyConfigParameterValue
so.topic: reference
---

Gets the string value of an Audience configuration parameter belonging to the currently logged on user with the specified configuration parameter name.

**Parameters:**
 - **parameterName** The name of the Audience configuration parameter

**Returns:** The string value of the Audience configuration parameter.

```crmscript
NSAudienceAgent agent;
String parameterName;
String res = agent.GetMyConfigParameterValue(parameterName);
```

