---
uid: listagent-setrankonsaleactivity
title: ListAgent.SetRankOnSaleActivity event method
description: Scripting events called on the SetRankOnSaleActivity method on the ListAgent service agent.
so.generated: true
keywords: netserver scripting
so.topic: reference
so.envir: onsite
---
# ListAgent.SetRankOnSaleActivity

Scripting events called on the <see cref='M:IListAgent.SetRankOnSaleActivity'>SetRankOnSaleActivity</see> method on the <see cref='IListAgent'>IListAgent</see>  service agent.

## BeforeSetRankOnSaleActivity
```cs
    static void BeforeSetRankOnSaleActivity(
       Int32  saleTypeStageLinkId,
       Int32[]  itemsIds,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSetRankOnSaleActivity
```cs
    static void AfterSetRankOnSaleActivity(
       Int32  saleTypeStageLinkId,
       Int32[]  itemsIds,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSetRankOnSaleActivityAsync
```cs
    static void AfterSetRankOnSaleActivityAsync(
       Int32  saleTypeStageLinkId,
       Int32[]  itemsIds,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

