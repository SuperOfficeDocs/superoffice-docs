---
uid: IArchiveAgent-SetColumnWidthsV2
title: IArchiveAgent.SetColumnWidthsV2 event method
description: Scripting events called on the SetColumnWidthsV2 method on the IArchiveAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IArchiveAgent.SetColumnWidthsV2

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IArchiveAgent.SetColumnWidthsV2'>SetColumnWidthsV2</see> method on the <see cref='IArchiveAgent'>IArchiveAgent</see>  service agent.

## BeforeSetColumnWidthsV2
```cs
    static void BeforeSetColumnWidthsV2(
       String  guiName,
       String  providerName,
       String  context,
       String  ownerKeys,
       String[]  columnWidths,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSetColumnWidthsV2
```cs
    static void AfterSetColumnWidthsV2(
       String  guiName,
       String  providerName,
       String  context,
       String  ownerKeys,
       String[]  columnWidths,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSetColumnWidthsV2Async
```cs
    static void AfterSetColumnWidthsV2Async(
       String  guiName,
       String  providerName,
       String  context,
       String  ownerKeys,
       String[]  columnWidths,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

