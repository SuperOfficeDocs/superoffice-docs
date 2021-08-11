---
uid: crmscript_ref_NSProjectAgent_GetMyProjectEvents
title: NSProjectEvent[] GetMyProjectEvents()
intellisense: NSProjectAgent.GetMyProjectEvents
keywords: NSProjectAgent, GetMyProjectEvents
so.topic: reference
---

# NSProjectEvent[] GetMyProjectEvents()

Gets all project events that belongs to the currently logged on user. The list of events are filtered by the Audience Visibility restrictions set when the project event is created.

**Returns:** NSProjectEvent[]

```crmscript
NSProjectAgent agent;
NSProjectEvent[] res = agent.GetMyProjectEvents();
```

