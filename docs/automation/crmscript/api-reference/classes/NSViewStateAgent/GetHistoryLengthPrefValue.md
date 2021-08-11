---
uid: crmscript_ref_NSViewStateAgent_GetHistoryLengthPrefValue
title: Integer GetHistoryLengthPrefValue()
intellisense: NSViewStateAgent.GetHistoryLengthPrefValue
keywords: NSViewStateAgent, GetHistoryLengthPrefValue
so.topic: reference
---

# Integer GetHistoryLengthPrefValue()

Get the logged on user's preferred history list length. Will return the system preference if no user preferences are available.

**Returns:** Integer

```crmscript
NSViewStateAgent agent;
Integer res = agent.GetHistoryLengthPrefValue();
```

