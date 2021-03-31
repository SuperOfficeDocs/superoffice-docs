---
title: crmscript_ref_NSAppointmentAgent_SaveAppointmentEntity
description: NSAppointmentEntity SaveAppointmentEntity(NSAppointmentEntity appointmentEntity);
intellisense: NSAppointmentAgent.SaveAppointmentEntity
keywords: NSAppointmentAgent,SaveAppointmentEntity
so.topic: reference
---
	  
Updates the existing NSAppointmentEntity or creates a new NSAppointmentEntity if the id parameter is 0
	  
**Parameters**:
 - **appointmentEntity** The NSAppointmentEntity to save.

**Returns:** New or updated NSAppointmentEntity

```crmscript
NSAppointment  agent;
NSAppointmentEntity thing = agent.CreateDefaultAppointmentEntity();
thing = agent.SaveAppointmentEntity(thing);
```

