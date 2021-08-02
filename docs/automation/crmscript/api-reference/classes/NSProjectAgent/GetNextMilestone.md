---
uid: crmscript_ref_NSProjectAgent_GetNextMilestone
title: NSAppointment GetNextMilestone(Integer projectId)
intellisense: NSProjectAgent.GetNextMilestone
keywords: NSProjectAgent, GetNextMilestone
so.topic: reference
---

Next upcoming milestone appointment

**Parameters:**
 - **projectId** Project id - primary key

**Returns:** NSAppointment

```crmscript
NSProjectAgent agent;
Integer projectId;
NSAppointment res = agent.GetNextMilestone(projectId);
```

