---
uid: crmscript_ref_NSPreferenceAgent_DeletePrefDescLinesByPrefDescId
title: Void DeletePrefDescLinesByPrefDescId(Integer prefDescId)
intellisense: NSPreferenceAgent.DeletePrefDescLinesByPrefDescId
keywords: NSPreferenceAgent, DeletePrefDescLinesByPrefDescId
so.topic: reference
---

Delete the PrefDescLines associated with Preference Description Id in the SuperOffice database

**Parameters:**
 - **prefDescId** Primary key of the Preference Description that contains PrefDescLines to delete

**Returns:** Nothing

```crmscript
NSPreferenceAgent agent;
Integer prefDescId;
Void res = agent.DeletePrefDescLinesByPrefDescId(prefDescId);
```

