---
title: crmscript_ref_NSPreferenceAgent_DeletePrefDescLinesByPrefDescIds
description: Void DeletePrefDescLinesByPrefDescIds(IntegerArray prefDescIds)
intellisense: NSPreferenceAgent.DeletePrefDescLinesByPrefDescIds
keywords: NSPreferenceAgent,DeletePrefDescLinesByPrefDescIds
so.topic: reference
---

Delete the PrefDescLines associated with Preference Description Ids in the SuperOffice database

**Parameters:**
 - **prefDescIds** Primary keys of the Preference Descriptions that contains PrefDescLines to delete

**Returns:** Nothing

```crmscript
NSPreferenceAgent agent;
IntegerArray prefDescIds;
Void res = agent.DeletePrefDescLinesByPrefDescIds(prefDescIds);
```

