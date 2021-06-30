---
uid: crmscript_ref_NSProjectAgent_GetProjectEventsOnPerson
title: ProjectEvent[] GetProjectEventsOnPerson(Integer personId)
intellisense: NSProjectAgent.GetProjectEventsOnPerson
keywords: NSProjectAgent, GetProjectEventsOnPerson
so.topic: reference
---

Gets all project events that belongs to the person specified. The list of events are filtered by the Audience Visibility restrictions set when the project event is created.

**Parameters:**
 - **personId** Id of the person the project events belong to.

**Returns:** Array of project events

```crmscript
NSProjectAgent agent;
Integer personId;
ProjectEvent[] res = agent.GetProjectEventsOnPerson(personId);
```

