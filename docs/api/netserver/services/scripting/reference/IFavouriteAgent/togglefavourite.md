---
uid: IFavouriteAgent-ToggleFavourite
title: IFavouriteAgent.ToggleFavourite event method
description: Scripting events called on the ToggleFavourite method on the IFavouriteAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IFavouriteAgent.ToggleFavourite

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IFavouriteAgent.ToggleFavourite'>ToggleFavourite</see> method on the <see cref='IFavouriteAgent'>IFavouriteAgent</see>  service agent.

## BeforeToggleFavourite
```cs
    static void BeforeToggleFavourite(
       String  tableName,
       Int32  recordId,
       Int32  associateId,
       String  extraInfo,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterToggleFavourite
```cs
    static void AfterToggleFavourite(
       String  tableName,
       Int32  recordId,
       Int32  associateId,
       String  extraInfo,
       ref Boolean  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterToggleFavouriteAsync
```cs
    static void AfterToggleFavouriteAsync(
       String  tableName,
       Int32  recordId,
       Int32  associateId,
       String  extraInfo,
       ref Boolean  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

