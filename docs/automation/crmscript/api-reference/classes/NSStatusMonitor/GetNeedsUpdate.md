---
uid: crmscript_ref_NSStatusMonitor_GetNeedsUpdate
title: Bool GetNeedsUpdate()
intellisense: NSStatusMonitor.GetNeedsUpdate
keywords: NSStatusMonitor, GetNeedsUpdate
so.topic: reference
---

# Bool GetNeedsUpdate()

Is the definition dirty, ie., ALL values are invalid until a recalculation; this flag is set when the status DEFINITION is changed, as opposed to the flag on StatusValue

**Returns:** Bool

```crmscript
NSStatusMonitor thing;
Bool needsUpdate  = thing.GetNeedsUpdate();
```

