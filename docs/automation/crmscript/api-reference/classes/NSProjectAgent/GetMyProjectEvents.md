---
uid: crmscript_ref_NSProjectAgent_GetMyProjectEvents
title: ProjectEvent[] GetMyProjectEvents()
intellisense: NSProjectAgent.GetMyProjectEvents
keywords: NSProjectAgent, GetMyProjectEvents
so.topic: reference
---

Gets all project events that belongs to the currently logged on user. The list of events are filtered by the Audience Visibility restrictions set when the project event is created.


**Returns:** Array of project events

```crmscript
NSProjectAgent agent;
ProjectEvent[] res = agent.GetMyProjectEvents();
```

