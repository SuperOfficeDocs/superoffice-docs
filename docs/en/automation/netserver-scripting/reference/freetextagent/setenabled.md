---
uid: freetextagent-setenabled
title: FreeTextAgent.SetEnabled event method
description: Scripting events called on the SetEnabled method on the FreeTextAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 11.29.2022
so.topic: reference
so.envir:
  - "onsite"
---
# FreeTextAgent.SetEnabled

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IFreeTextAgent.SetEnabled'>SetEnabled</see> method on the <see cref='IFreeTextAgent'>IFreeTextAgent</see>  service agent.

## BeforeSetEnabled
```cs
    static void BeforeSetEnabled(
       Boolean  enabled,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSetEnabled
```cs
    static void AfterSetEnabled(
       Boolean  enabled,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSetEnabledAsync
```cs
    static void AfterSetEnabledAsync(
       Boolean  enabled,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

