---
uid: crmscript_ref_NSStatusMonitor_SetNeedsUpdate
title: SetNeedsUpdate(Bool needsUpdate)
intellisense: NSStatusMonitor.SetNeedsUpdate
keywords: NSStatusMonitor, GetNeedsUpdate
so.topic: reference
---

# SetNeedsUpdate(Bool needsUpdate)

Is the definition dirty, ie., ALL values are invalid until a recalculation; this flag is set when the status DEFINITION is changed, as opposed to the flag on StatusValue

**Parameter:** 
 - **needsUpdate** Bool

```crmscript
NSStatusMonitor thing;
Bool needsUpdate;
thing.SetNeedsUpdate(needsUpdate);
```

