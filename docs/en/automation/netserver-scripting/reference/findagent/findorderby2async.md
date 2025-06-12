---
uid: findagent-findorderby2async
title: FindAgent.FindOrderBy2Async event method
description: Scripting events called on the FindOrderBy2Async method on the FindAgent service agent.
so.generated: true
keywords: netserver scripting
so.topic: reference
so.envir: onsite
---
# FindAgent.FindOrderBy2Async

Scripting events called on the <see cref='M:IFindAgent.FindOrderBy2Async'>FindOrderBy2Async</see> method on the <see cref='IFindAgent'>IFindAgent</see>  service agent.

## BeforeFindOrderBy2Async
```cs
    static void BeforeFindOrderBy2Async(
       String  storageType,
       String  providerName,
       String  storageKey,
       Int32  pageSize,
       Int32  pageNumber,
       String  orderBy,
       CancellationToken  cancellationToken,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterFindOrderBy2Async
```cs
    static void AfterFindOrderBy2Async(
       String  storageType,
       String  providerName,
       String  storageKey,
       Int32  pageSize,
       Int32  pageNumber,
       String  orderBy,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterFindOrderBy2AsyncAsync
```cs
    static void AfterFindOrderBy2AsyncAsync(
       String  storageType,
       String  providerName,
       String  storageKey,
       Int32  pageSize,
       Int32  pageNumber,
       String  orderBy,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

