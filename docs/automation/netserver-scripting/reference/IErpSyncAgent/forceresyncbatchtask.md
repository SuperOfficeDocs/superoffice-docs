---
uid: IErpSyncAgent-ForceResyncBatchTask
title: IErpSyncAgent.ForceResyncBatchTask event method
description: Scripting events called on the ForceResyncBatchTask method on the IErpSyncAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IErpSyncAgent.ForceResyncBatchTask

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IErpSyncAgent.ForceResyncBatchTask'>ForceResyncBatchTask</see> method on the <see cref='IErpSyncAgent'>IErpSyncAgent</see>  service agent.

## BeforeForceResyncBatchTask
```cs
    static void BeforeForceResyncBatchTask(
       Int32  erpConnectionId,
       Int32[]  internalKeyIds,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterForceResyncBatchTask
```cs
    static void AfterForceResyncBatchTask(
       Int32  erpConnectionId,
       Int32[]  internalKeyIds,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterForceResyncBatchTaskAsync
```cs
    static void AfterForceResyncBatchTaskAsync(
       Int32  erpConnectionId,
       Int32[]  internalKeyIds,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

