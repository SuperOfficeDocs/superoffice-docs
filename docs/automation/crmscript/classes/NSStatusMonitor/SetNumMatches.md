---
uid: crmscript_ref_NSStatusMonitor_SetNumMatches
title: SetNumMatches(Integer numMatches)
intellisense: NSStatusMonitor.SetNumMatches
keywords: NSStatusMonitor, GetNumMatches
so.topic: reference
---

Number of targets that have this status, this should be the number of rows in StatusValue pointing to this definition, and that have isSignalled set to 1

**Parameter:** 
 - **numMatches** Integer

```crmscript
NSStatusMonitor thing;
Integer numMatches;
thing.SetNumMatches(numMatches);
```

