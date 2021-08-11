---
uid: crmscript_ref_NSActivitySummary_GetNumBusyActivities
title: Integer GetNumBusyActivities()
intellisense: NSActivitySummary.GetNumBusyActivities
keywords: NSActivitySummary, GetNumBusyActivities
so.topic: reference
---

# Integer GetNumBusyActivities()

Number of activites and tasks in the diary that are of type 'busy'. Sales and documents are not activites in this case, only diary appointments and tasks.

**Returns:** Integer

```crmscript
NSActivitySummary thing;
Integer numBusyActivities  = thing.GetNumBusyActivities();
```

