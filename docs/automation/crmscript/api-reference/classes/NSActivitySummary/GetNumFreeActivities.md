---
uid: crmscript_ref_NSActivitySummary_GetNumFreeActivities
title: Integer GetNumFreeActivities()
intellisense: NSActivitySummary.GetNumFreeActivities
keywords: NSActivitySummary, GetNumFreeActivities
so.topic: reference
---

# Integer GetNumFreeActivities()

Number of activites of the type 'free'. Sales and documents are not activites in this case, only diary appointments and tasks.

**Returns:** Integer

```crmscript
NSActivitySummary thing;
Integer numFreeActivities  = thing.GetNumFreeActivities();
```

