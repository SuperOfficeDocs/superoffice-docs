---
title: crmscript_ref_NSAppointmentAgent_CreateDefaultTaskListItem
description: NSTaskListItem CreateDefaultTaskListItem()
intellisense: NSAppointmentAgent.CreateDefaultTaskListItem
keywords: NSAppointmentAgent,CreateDefaultTaskListItem
so.topic: reference
---
	  
Set default values into a new NSTaskListItem.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSTaskListItem with default values.

```crmscript
NSAppointmentAgent agent;
NSTaskListItem thing = agent.CreateDefaultTaskListItem();
thing = agent.SaveTaskListItem(thing);
```

