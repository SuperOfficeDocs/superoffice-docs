---
uid: crmscript_ref_NSEMailAgent_CreateDefaultEMailAppointment
title: NSEMailAppointment CreateDefaultEMailAppointment()
intellisense: NSEMailAgent.CreateDefaultEMailAppointment
keywords: NSEMailAgent, CreateDefaultEMailAppointment
so.topic: reference
---

# NSEMailAppointment CreateDefaultEMailAppointment()
	  
Set default values into a new NSEMailAppointment.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** NSEMailAppointment

```crmscript
NSEMailAgent agent;
NSEMailAppointment thing = agent.CreateDefaultEMailAppointment();
thing = agent.SaveEMailAppointment(thing);
```

