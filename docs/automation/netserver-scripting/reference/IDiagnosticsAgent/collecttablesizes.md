---
uid: IDiagnosticsAgent-CollectTableSizes
title: IDiagnosticsAgent.CollectTableSizes event method
description: Scripting events called on the CollectTableSizes method on the IDiagnosticsAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IDiagnosticsAgent.CollectTableSizes

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IDiagnosticsAgent.CollectTableSizes'>CollectTableSizes</see> method on the <see cref='IDiagnosticsAgent'>IDiagnosticsAgent</see>  service agent.

## BeforeCollectTableSizes
```cs
    static void BeforeCollectTableSizes(
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterCollectTableSizes
```cs
    static void AfterCollectTableSizes(
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterCollectTableSizesAsync
```cs
    static void AfterCollectTableSizesAsync(
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

