---
uid: crmscript_ref_NSAudienceAgent_GetConfigParametersOnPerson
title: NSAudienceConfigParameter[] GetConfigParametersOnPerson(Integer personId)
intellisense: NSAudienceAgent.GetConfigParametersOnPerson
keywords: NSAudienceAgent, GetConfigParametersOnPerson
so.topic: reference
---

# NSAudienceConfigParameter[] GetConfigParametersOnPerson(Integer personId)

Gets the Audience configuration parameters belonging to the person specified

**Parameters:**
 - **personId** Id of the person the parameter belongs to

**Returns:** Array of Audience configuration parameters.

```crmscript
NSAudienceAgent agent;
Integer personId;
NSAudienceConfigParameter[] res = agent.GetConfigParametersOnPerson(personId);
```

