---
title: crmscript_ref_NSPreferenceAgent_DeletePreferenceDescriptionLines
description: Void DeletePreferenceDescriptionLines(IntegerArray prefDescLineIds)
intellisense: NSPreferenceAgent.DeletePreferenceDescriptionLines
keywords: NSPreferenceAgent,DeletePreferenceDescriptionLines
so.topic: reference
---

Delete the PrefDescLines in the SuperOffice database

**Parameters:**
 - **prefDescLineIds** Primary keys of the PrefDescLines to delete

**Returns:** Nothing

```crmscript
NSPreferenceAgent agent;
IntegerArray prefDescLineIds;
Void res = agent.DeletePreferenceDescriptionLines(prefDescLineIds);
```

