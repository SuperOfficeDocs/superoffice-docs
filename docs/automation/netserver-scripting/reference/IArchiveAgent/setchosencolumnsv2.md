---
uid: IArchiveAgent-SetChosenColumnsV2
title: IArchiveAgent.SetChosenColumnsV2 event method
description: Scripting events called on the SetChosenColumnsV2 method on the IArchiveAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IArchiveAgent.SetChosenColumnsV2

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IArchiveAgent.SetChosenColumnsV2'>SetChosenColumnsV2</see> method on the <see cref='IArchiveAgent'>IArchiveAgent</see>  service agent.

## BeforeSetChosenColumnsV2
```cs
    static void BeforeSetChosenColumnsV2(
       String  guiName,
       String  providerName,
       String  context,
       String  ownerKeys,
       String[]  chosenColumns,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSetChosenColumnsV2
```cs
    static void AfterSetChosenColumnsV2(
       String  guiName,
       String  providerName,
       String  context,
       String  ownerKeys,
       String[]  chosenColumns,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSetChosenColumnsV2Async
```cs
    static void AfterSetChosenColumnsV2Async(
       String  guiName,
       String  providerName,
       String  context,
       String  ownerKeys,
       String[]  chosenColumns,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

