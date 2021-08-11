---
uid: crmscript_ref_NSAudienceAgent_GetConfigParameterValueOnPerson
title: String GetConfigParameterValueOnPerson(String parameterName, Integer personId)
intellisense: NSAudienceAgent.GetConfigParameterValueOnPerson
keywords: NSAudienceAgent, GetConfigParameterValueOnPerson
so.topic: reference
---

# String GetConfigParameterValueOnPerson(String parameterName, Integer personId)

Gets the string value of an Audience configuration parameter with the specified configuration parameter name on the person specified

**Parameters:**
 - **parameterName** The name of the Audience configuration parameter
 - **personId** Id of the person the parameter belongs to

**Returns:** The string value of the Audience configuration parameter.

```crmscript
NSAudienceAgent agent;
String parameterName;
Integer personId;
String res = agent.GetConfigParameterValueOnPerson(parameterName, personId);
```

