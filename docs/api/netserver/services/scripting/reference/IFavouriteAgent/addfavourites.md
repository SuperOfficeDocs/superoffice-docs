---
uid: IFavouriteAgent-AddFavourites
title: IFavouriteAgent.AddFavourites event method
description: Scripting events called on the AddFavourites method on the IFavouriteAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IFavouriteAgent.AddFavourites

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IFavouriteAgent.AddFavourites'>AddFavourites</see> method on the <see cref='IFavouriteAgent'>IFavouriteAgent</see>  service agent.

## BeforeAddFavourites
```cs
    static void BeforeAddFavourites(
       String  tableName,
       Int32[]  recordIds,
       Int32  associateId,
       String  extraInfo,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterAddFavourites
```cs
    static void AfterAddFavourites(
       String  tableName,
       Int32[]  recordIds,
       Int32  associateId,
       String  extraInfo,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterAddFavouritesAsync
```cs
    static void AfterAddFavouritesAsync(
       String  tableName,
       Int32[]  recordIds,
       Int32  associateId,
       String  extraInfo,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

