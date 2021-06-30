---
uid: crmscript_ref_NSViewStateAgent_SaveCurrents
title: History[] SaveCurrents(History[] currents)
intellisense: NSViewStateAgent.SaveCurrents
keywords: NSViewStateAgent, SaveCurrents
so.topic: reference
---

Saves the history elements as the current value for their respective lists. If more than one item is submitted for the same list, they are added sequently, meaning that the last one is the most current.

**Parameters:**
 - **currents** Array of new history items to save.

**Returns:** Array of the saved History items

```crmscript
NSViewStateAgent agent;
History[] currents;
History[] res = agent.SaveCurrents(currents);
```

