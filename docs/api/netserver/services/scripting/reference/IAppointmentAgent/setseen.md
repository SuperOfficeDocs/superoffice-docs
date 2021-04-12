---
uid: IAppointmentAgent-SetSeen
title: IAppointmentAgent.SetSeen event method
description: Scripting events called on the SetSeen method on the IAppointmentAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IAppointmentAgent.SetSeen

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IAppointmentAgent.SetSeen'>SetSeen</see> method on the <see cref='IAppointmentAgent'>IAppointmentAgent</see>  service agent.

## BeforeSetSeen
```cs
    static void BeforeSetSeen(
       Int32  appointmentId,
       RecurrenceUpdateMode  updateMode,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSetSeen
```cs
    static void AfterSetSeen(
       Int32  appointmentId,
       RecurrenceUpdateMode  updateMode,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSetSeenAsync
```cs
    static void AfterSetSeenAsync(
       Int32  appointmentId,
       RecurrenceUpdateMode  updateMode,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

