---
uid: INumberAllocationAgent-SetNumberEachTemplate
title: INumberAllocationAgent.SetNumberEachTemplate event method
description: Scripting events called on the SetNumberEachTemplate method on the INumberAllocationAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# INumberAllocationAgent.SetNumberEachTemplate

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.INumberAllocationAgent.SetNumberEachTemplate'>SetNumberEachTemplate</see> method on the <see cref='INumberAllocationAgent'>INumberAllocationAgent</see>  service agent.

## BeforeSetNumberEachTemplate
```cs
    static void BeforeSetNumberEachTemplate(
       Boolean  setValue,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSetNumberEachTemplate
```cs
    static void AfterSetNumberEachTemplate(
       Boolean  setValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSetNumberEachTemplateAsync
```cs
    static void AfterSetNumberEachTemplateAsync(
       Boolean  setValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

