---
uid: crmscript_ref_NSAppointmentAgent_CreateDefaultAppointmentEntity
title: NSAppointmentEntity CreateDefaultAppointmentEntity()
intellisense: NSAppointmentAgent.CreateDefaultAppointmentEntity
keywords: NSAppointmentAgent, CreateDefaultAppointmentEntity
so.topic: reference
---
	  
Set default values into a new NSAppointmentEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSAppointmentEntity with default values.

```crmscript
NSAppointmentAgent agent;
NSAppointmentEntity thing = agent.CreateDefaultAppointmentEntity();
thing = agent.SaveAppointmentEntity(thing);
```

