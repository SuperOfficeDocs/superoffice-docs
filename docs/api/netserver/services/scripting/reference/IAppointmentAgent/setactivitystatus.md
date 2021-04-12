---
uid: IAppointmentAgent-SetActivityStatus
title: IAppointmentAgent.SetActivityStatus event method
description: Scripting events called on the SetActivityStatus method on the IAppointmentAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IAppointmentAgent.SetActivityStatus

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IAppointmentAgent.SetActivityStatus'>SetActivityStatus</see> method on the <see cref='IAppointmentAgent'>IAppointmentAgent</see>  service agent.

## BeforeSetActivityStatus
```cs
    static void BeforeSetActivityStatus(
       String[]  activityIdentifier,
       ActivityStatus  activityStatus,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSetActivityStatus
```cs
    static void AfterSetActivityStatus(
       String[]  activityIdentifier,
       ActivityStatus  activityStatus,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSetActivityStatusAsync
```cs
    static void AfterSetActivityStatusAsync(
       String[]  activityIdentifier,
       ActivityStatus  activityStatus,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

