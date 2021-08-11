---
uid: crmscript_ref_NSViewStateAgent_SaveCurrent
title: NSHistory SaveCurrent(NSHistory current)
intellisense: NSViewStateAgent.SaveCurrent
keywords: NSViewStateAgent, SaveCurrent
so.topic: reference
---

# NSHistory SaveCurrent(NSHistory current)

Saving the current history item. This history item is saved with Rank = 1, and all the remaining elements rank values are shifted one down. The list is maintained with the max lenght of the History list length preference.

**Parameters:**
 - **current** The new current history element.

**Returns:** NSHistory

```crmscript
NSViewStateAgent agent;
NSHistory current;
NSHistory res = agent.SaveCurrent(current);
```

