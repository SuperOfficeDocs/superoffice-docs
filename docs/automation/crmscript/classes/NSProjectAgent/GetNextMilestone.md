---
title: crmscript_ref_NSProjectAgent_GetNextMilestone
description: Appointment GetNextMilestone(Integer projectId)
intellisense: NSProjectAgent.GetNextMilestone
keywords: NSProjectAgent,GetNextMilestone
so.topic: reference
---

Next upcoming milestone appointment

**Parameters:**
 - **projectId** Project id - primary key

**Returns:** Upcoming milestone appointment

```crmscript
NSProjectAgent agent;
Integer projectId;
Appointment res = agent.GetNextMilestone(projectId);
```

