---
uid: ISelectionAgent-DeleteSelectionEntity
title: ISelectionAgent.DeleteSelectionEntity event method
description: Scripting events called on the DeleteSelectionEntity method on the ISelectionAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
---
# ISelectionAgent.DeleteSelectionEntity

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.ISelectionAgent.DeleteSelectionEntity'>DeleteSelectionEntity</see> method on the <see cref='ISelectionAgent'>ISelectionAgent</see>  service agent.

## BeforeDeleteSelectionEntity
```cs
    static void BeforeDeleteSelectionEntity(
       Int32  selectionEntityId,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterDeleteSelectionEntity
```cs
    static void AfterDeleteSelectionEntity(
       Int32  selectionEntityId,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterDeleteSelectionEntityAsync
```cs
    static void AfterDeleteSelectionEntityAsync(
       Int32  selectionEntityId,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

