---
title: crmscript_ref_NSAppointmentAgent_SaveSuggestedAppointmentEntity
description: NSSuggestedAppointmentEntity SaveSuggestedAppointmentEntity(NSSuggestedAppointmentEntity suggestedAppointmentEntity);
intellisense: NSAppointmentAgent.SaveSuggestedAppointmentEntity
keywords: NSAppointmentAgent,SaveSuggestedAppointmentEntity
so.topic: reference
---
	  
Updates the existing NSSuggestedAppointmentEntity or creates a new NSSuggestedAppointmentEntity if the id parameter is 0
	  
**Parameters**:
 - **suggestedAppointmentEntity** The NSSuggestedAppointmentEntity to save.

**Returns:** New or updated NSSuggestedAppointmentEntity

```crmscript
NSAppointment  agent;
NSSuggestedAppointmentEntity thing = agent.CreateDefaultSuggestedAppointmentEntity();
thing = agent.SaveSuggestedAppointmentEntity(thing);
```

