---
uid: crmscript_ref_NSAppointmentAgent_CreateDefaultReOpenAppointment
title: NSAppointmentEntity CreateDefaultReOpenAppointment(Integer saleId)
intellisense: NSAppointmentAgent.CreateDefaultReOpenAppointment
keywords: NSAppointmentAgent, CreateDefaultReOpenAppointment
so.topic: reference
---

# NSAppointmentEntity CreateDefaultReOpenAppointment(Integer saleId)

A re-open appointment should be created as a reminder to re-open the sale at a certain date with information regarding the stalled sale. 

**Parameters:**
 - **saleId** The identifier of the stalled sale from which we create a re-open appointment

**Returns:** The re-open appointment with start date = the re-open date of the sale and a description matching the sales stalled reason. 

```crmscript
NSAppointmentAgent agent;
Integer saleId;
NSAppointmentEntity res = agent.CreateDefaultReOpenAppointment(saleId);
```

