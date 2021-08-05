---
uid: ISaleAgent-DeleteSaleEntity
title: ISaleAgent.DeleteSaleEntity event method
description: Scripting events called on the DeleteSaleEntity method on the ISaleAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# ISaleAgent.DeleteSaleEntity

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.ISaleAgent.DeleteSaleEntity'>DeleteSaleEntity</see> method on the <see cref='ISaleAgent'>ISaleAgent</see>  service agent.

## BeforeDeleteSaleEntity
```cs
    static void BeforeDeleteSaleEntity(
       Int32  saleEntityId,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterDeleteSaleEntity
```cs
    static void AfterDeleteSaleEntity(
       Int32  saleEntityId,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterDeleteSaleEntityAsync
```cs
    static void AfterDeleteSaleEntityAsync(
       Int32  saleEntityId,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

