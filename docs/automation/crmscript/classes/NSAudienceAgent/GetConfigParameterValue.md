---
uid: crmscript_ref_NSAudienceAgent_GetConfigParameterValue
title: String GetConfigParameterValue(String layoutName, String parameterName)
intellisense: NSAudienceAgent.GetConfigParameterValue
keywords: NSAudienceAgent, GetConfigParameterValue
so.topic: reference
---

Gets the string value of an Audience configuration parameter belonging to a given Audience layout with the specified configuration parameter name

**Parameters:**
 - **layoutName** Name of the Audience layout instance
 - **parameterName** The name of the Audience configuration parameter

**Returns:** The string value of the Audience configuration parameter.

```crmscript
NSAudienceAgent agent;
String layoutName;
String parameterName;
String res = agent.GetConfigParameterValue(layoutName, parameterName);
```

