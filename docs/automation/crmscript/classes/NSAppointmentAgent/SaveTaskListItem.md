---
uid: crmscript_ref_NSAppointmentAgent_SaveTaskListItem
title: NSTaskListItem SaveTaskListItem(NSTaskListItem taskListItem);
intellisense: NSAppointmentAgent.SaveTaskListItem
keywords: NSAppointmentAgent, SaveTaskListItem
so.topic: reference
---
	  
Updates the existing NSTaskListItem or creates a new NSTaskListItem if the id parameter is 0
	  
**Parameters**:
 - **taskListItem** The NSTaskListItem to save.

**Returns:** New or updated NSTaskListItem

```crmscript
NSAppointment  agent;
NSTaskListItem thing = agent.CreateDefaultTaskListItem();
thing = agent.SaveTaskListItem(thing);
```

