---
uid: crmscript_class_nsappointmentagent_saveappointmententity
title: NSAppointmentEntity SaveAppointmentEntity()
description: CRMScript method in the NSAppointmentAgent class that saves an appointment
intellisense: NSAppointmentAgent.SaveAppointmentEntity
keywords: NSAppointmentAgent, SaveAppointmentEntity, SaveAppointmentEntity(NSAppointmentEntity)
so.topic: reference
---

# SaveAppointmentEntity()

Updates the existing NSAppointmentEntity or creates a new NSAppointmentEntity if the ID parameter is 0.

Returns the new or updated NSAppointmentEntity.

`NSAppointmentEntity SaveAppointmentEntity(NSAppointmentEntity appointmentEntity)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| appointmentEntity | NSAppointmentEntity | The NSAppointmentEntity to save. |

## Example

```crmscript
NSAppointment  agent;
NSAppointmentEntity thing = agent.CreateDefaultAppointmentEntity();
thing = agent.SaveAppointmentEntity(thing);
```
