---
uid: IListAgent-SetRankOnProjectActivity
title: IListAgent.SetRankOnProjectActivity event method
description: Scripting events called on the SetRankOnProjectActivity method on the IListAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IListAgent.SetRankOnProjectActivity

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IListAgent.SetRankOnProjectActivity'>SetRankOnProjectActivity</see> method on the <see cref='IListAgent'>IListAgent</see>  service agent.

## BeforeSetRankOnProjectActivity
```cs
    static void BeforeSetRankOnProjectActivity(
       Int32  projectTypeStatusLinkId,
       Int32[]  itemsIds,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSetRankOnProjectActivity
```cs
    static void AfterSetRankOnProjectActivity(
       Int32  projectTypeStatusLinkId,
       Int32[]  itemsIds,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSetRankOnProjectActivityAsync
```cs
    static void AfterSetRankOnProjectActivityAsync(
       Int32  projectTypeStatusLinkId,
       Int32[]  itemsIds,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

