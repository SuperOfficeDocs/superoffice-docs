---
uid: crmscript_ref_NSPreferenceAgent_DeletePrefDescLinesByPrefDescIds
title: Void DeletePrefDescLinesByPrefDescIds(Integer[] prefDescIds)
intellisense: NSPreferenceAgent.DeletePrefDescLinesByPrefDescIds
keywords: NSPreferenceAgent, DeletePrefDescLinesByPrefDescIds
so.topic: reference
---

Delete the PrefDescLines associated with Preference Description Ids in the SuperOffice database

**Parameters:**
 - **prefDescIds** Primary keys of the Preference Descriptions that contains PrefDescLines to delete

```crmscript
NSPreferenceAgent agent;
Integer[] prefDescIds;
agent.DeletePrefDescLinesByPrefDescIds(prefDescIds);
```

