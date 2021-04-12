---
uid: IBLOBAgent-ChangeProductImage
title: IBLOBAgent.ChangeProductImage event method
description: Scripting events called on the ChangeProductImage method on the IBLOBAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IBLOBAgent.ChangeProductImage

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IBLOBAgent.ChangeProductImage'>ChangeProductImage</see> method on the <see cref='IBLOBAgent'>IBLOBAgent</see>  service agent.

## BeforeChangeProductImage
```cs
    static void BeforeChangeProductImage(
       Int32  productId,
       Int32  blobId,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterChangeProductImage
```cs
    static void AfterChangeProductImage(
       Int32  productId,
       Int32  blobId,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterChangeProductImageAsync
```cs
    static void AfterChangeProductImageAsync(
       Int32  productId,
       Int32  blobId,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

