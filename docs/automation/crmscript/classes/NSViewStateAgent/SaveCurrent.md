---
uid: crmscript_ref_NSViewStateAgent_SaveCurrent
title: History SaveCurrent(History current)
intellisense: NSViewStateAgent.SaveCurrent
keywords: NSViewStateAgent, SaveCurrent
so.topic: reference
---

Saving the current history item. This history item is saved with Rank = 1, and all the remaining elements rank values are shifted one down. The list is maintained with the max lenght of the History list length preference.

**Parameters:**
 - **current** The new current history element.

**Returns:** The current (most recent) history item

```crmscript
NSViewStateAgent agent;
History current;
History res = agent.SaveCurrent(current);
```

