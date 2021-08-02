---
uid: crmscript_ref_NSPreferenceAgent_DeletePreferenceDescriptionLines
title: Void DeletePreferenceDescriptionLines(Integer[] prefDescLineIds)
intellisense: NSPreferenceAgent.DeletePreferenceDescriptionLines
keywords: NSPreferenceAgent, DeletePreferenceDescriptionLines
so.topic: reference
---

Delete the PrefDescLines in the SuperOffice database

**Parameters:**
 - **prefDescLineIds** Primary keys of the PrefDescLines to delete

```crmscript
NSPreferenceAgent agent;
Integer[] prefDescLineIds;
agent.DeletePreferenceDescriptionLines(prefDescLineIds);
```

