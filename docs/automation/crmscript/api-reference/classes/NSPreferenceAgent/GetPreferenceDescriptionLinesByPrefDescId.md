---
uid: crmscript_ref_NSPreferenceAgent_GetPreferenceDescriptionLinesByPrefDescId
title: NSPreferenceDescriptionLine[] GetPreferenceDescriptionLinesByPrefDescId(Integer prefDescId)
intellisense: NSPreferenceAgent.GetPreferenceDescriptionLinesByPrefDescId
keywords: NSPreferenceAgent, GetPreferenceDescriptionLinesByPrefDescId
so.topic: reference
---

Get all preference description lines from a prefDesc_id

**Parameters:**
 - **prefDescId** The id of the preference description this line is connected to

**Returns:** NSPreferenceDescriptionLine[]

```crmscript
NSPreferenceAgent agent;
Integer prefDescId;
NSPreferenceDescriptionLine[] res = agent.GetPreferenceDescriptionLinesByPrefDescId(prefDescId);
```

