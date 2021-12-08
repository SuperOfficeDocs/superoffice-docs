---
uid: IMarketingAgent-DeleteShipmentMessageBlockEntity
title: IMarketingAgent.DeleteShipmentMessageBlockEntity event method
description: Scripting events called on the DeleteShipmentMessageBlockEntity method on the IMarketingAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IMarketingAgent.DeleteShipmentMessageBlockEntity

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IMarketingAgent.DeleteShipmentMessageBlockEntity'>DeleteShipmentMessageBlockEntity</see> method on the <see cref='IMarketingAgent'>IMarketingAgent</see>  service agent.

## BeforeDeleteShipmentMessageBlockEntity
```cs
    static void BeforeDeleteShipmentMessageBlockEntity(
       Int32  shipmentMessageBlockEntityId,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterDeleteShipmentMessageBlockEntity
```cs
    static void AfterDeleteShipmentMessageBlockEntity(
       Int32  shipmentMessageBlockEntityId,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterDeleteShipmentMessageBlockEntityAsync
```cs
    static void AfterDeleteShipmentMessageBlockEntityAsync(
       Int32  shipmentMessageBlockEntityId,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

