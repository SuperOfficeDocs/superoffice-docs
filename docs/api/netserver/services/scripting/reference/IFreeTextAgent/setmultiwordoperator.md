---
uid: IFreeTextAgent-SetMultiWordOperator
title: IFreeTextAgent.SetMultiWordOperator event method
description: Scripting events called on the SetMultiWordOperator method on the IFreeTextAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IFreeTextAgent.SetMultiWordOperator

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IFreeTextAgent.SetMultiWordOperator'>SetMultiWordOperator</see> method on the <see cref='IFreeTextAgent'>IFreeTextAgent</see>  service agent.

## BeforeSetMultiWordOperator
```cs
    static void BeforeSetMultiWordOperator(
       FreeTextOperator  freeTextOperator,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSetMultiWordOperator
```cs
    static void AfterSetMultiWordOperator(
       FreeTextOperator  freeTextOperator,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSetMultiWordOperatorAsync
```cs
    static void AfterSetMultiWordOperatorAsync(
       FreeTextOperator  freeTextOperator,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

