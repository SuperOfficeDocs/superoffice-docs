---
title: crmscript_ref_NSEMailAgent_CreateDefaultEMailAppointment
description: NSEMailAppointment CreateDefaultEMailAppointment()
intellisense: NSEMailAgent.CreateDefaultEMailAppointment
keywords: NSEMailAgent,CreateDefaultEMailAppointment
so.topic: reference
---
	  
Set default values into a new NSEMailAppointment.
NetServer calculates default values (e.g. Country) on the entity, which is required when creating/storing a new instance
	  
**Returns:** A new NSEMailAppointment with default values.

```crmscript
NSEMailAgent agent;
NSEMailAppointment thing = agent.CreateDefaultEMailAppointment();
thing = agent.SaveEMailAppointment(thing);
```

