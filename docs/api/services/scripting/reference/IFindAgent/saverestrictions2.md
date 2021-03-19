---
uid: IFindAgent-SaveRestrictions2
title: IFindAgent.SaveRestrictions2 event method
description: Scripting events called on the SaveRestrictions2 method on the IFindAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IFindAgent.SaveRestrictions2

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IFindAgent.SaveRestrictions2'>SaveRestrictions2</see> method on the <see cref='IFindAgent'>IFindAgent</see>  service agent.

## BeforeSaveRestrictions2
```cs
    static void BeforeSaveRestrictions2(
       String  storageType,
       String  providerName,
       String  storageKey,
       String  restrictions,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSaveRestrictions2
```cs
    static void AfterSaveRestrictions2(
       String  storageType,
       String  providerName,
       String  storageKey,
       String  restrictions,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSaveRestrictions2Async
```cs
    static void AfterSaveRestrictions2Async(
       String  storageType,
       String  providerName,
       String  storageKey,
       String  restrictions,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

