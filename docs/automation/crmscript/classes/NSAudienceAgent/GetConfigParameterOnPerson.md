---
uid: crmscript_ref_NSAudienceAgent_GetConfigParameterOnPerson
title: AudienceConfigParameter GetConfigParameterOnPerson(String parameterName, Integer personId)
intellisense: NSAudienceAgent.GetConfigParameterOnPerson
keywords: NSAudienceAgent, GetConfigParameterOnPerson
so.topic: reference
---

Gets an Audience configuration parameter with the specified configuration parameter name on the person specified

**Parameters:**
 - **parameterName** The name of the Audience configuration parameter
 - **personId** Id of the person the parameter belongs to

**Returns:** The Audience configuration parameter.

```crmscript
NSAudienceAgent agent;
String parameterName;
Integer personId;
AudienceConfigParameter res = agent.GetConfigParameterOnPerson(parameterName, personId);
```

