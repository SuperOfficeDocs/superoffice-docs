---
uid: crmscript_ref_NSActivitySummary_SetNumFreeActivities
title: SetNumFreeActivities(Integer numFreeActivities)
intellisense: NSActivitySummary.SetNumFreeActivities
keywords: NSActivitySummary, GetNumFreeActivities
so.topic: reference
---

Number of activites of the type 'free'. Sales and documents are not activites in this case, only diary appointments and tasks.

**Parameter:** 
 - **numFreeActivities** Integer

```crmscript
NSActivitySummary thing;
Integer numFreeActivities;
thing.SetNumFreeActivities(numFreeActivities);
```

