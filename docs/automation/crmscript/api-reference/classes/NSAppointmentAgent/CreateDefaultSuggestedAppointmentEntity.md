---
uid: crmscript_ref_NSAppointmentAgent_CreateDefaultSuggestedAppointmentEntity
title: NSSuggestedAppointmentEntity CreateDefaultSuggestedAppointmentEntity()
intellisense: NSAppointmentAgent.CreateDefaultSuggestedAppointmentEntity
keywords: NSAppointmentAgent, CreateDefaultSuggestedAppointmentEntity
so.topic: reference
---

# NSSuggestedAppointmentEntity CreateDefaultSuggestedAppointmentEntity()
	  
Set default values into a new NSSuggestedAppointmentEntity.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSSuggestedAppointmentEntity with default values.

```crmscript
NSAppointmentAgent agent;
NSSuggestedAppointmentEntity thing = agent.CreateDefaultSuggestedAppointmentEntity();
thing = agent.SaveSuggestedAppointmentEntity(thing);
```

