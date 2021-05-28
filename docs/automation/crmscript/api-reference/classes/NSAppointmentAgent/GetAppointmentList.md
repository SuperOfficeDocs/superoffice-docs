---
uid: crmscript_class_nsappointmentagent_getappointmentlist
title: NSAppointment[] GetAppointmentList()
description: CRMScript method in the NSAppointmentAgent class that retrieves an array of NSAppointment objects
intellisense: NSAppointmentAgent.GetAppointmentList
keywords: NSAppointmentAgent, GetAppointmentList, GetAppointmentList(Integer[])
so.topic: reference
---

# GetAppointmentList()

Retrieves an array of `NSAppointment` objects.

`NSAppointment[] GetAppointmentList(Integer[] appointmentIds)`

## Parameters

| Parameter | Type | Description |
|---|---|---|
| appointmentIds | Integer[] | The identifiers of the appointments |

## Example

```crmscript
Integer[] ids;
NSAppointmentAgent agent;
agent.GetAppointmentList(ids);
```
