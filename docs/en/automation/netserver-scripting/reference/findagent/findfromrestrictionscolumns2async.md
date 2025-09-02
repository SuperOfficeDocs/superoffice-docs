---
uid: findagent-findfromrestrictionscolumns2async
title: FindAgent.FindFromRestrictionsColumns2Async event method
description: Scripting events called on the FindFromRestrictionsColumns2Async method on the FindAgent service agent.
generated: true
keywords: netserver scripting
content_type: reference
envir: onsite
---
# FindAgent.FindFromRestrictionsColumns2Async

Scripting events called on the <see cref='M:IFindAgent.FindFromRestrictionsColumns2Async'>FindFromRestrictionsColumns2Async</see> method on the <see cref='IFindAgent'>IFindAgent</see>  service agent.

## BeforeFindFromRestrictionsColumns2Async
```cs
    static void BeforeFindFromRestrictionsColumns2Async(
       String  restrictions,
       String  providerName,
       String  desiredColumns,
       Int32  pageSize,
       Int32  pageNumber,
       CancellationToken  cancellationToken,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterFindFromRestrictionsColumns2Async
```cs
    static void AfterFindFromRestrictionsColumns2Async(
       String  restrictions,
       String  providerName,
       String  desiredColumns,
       Int32  pageSize,
       Int32  pageNumber,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterFindFromRestrictionsColumns2AsyncAsync
```cs
    static void AfterFindFromRestrictionsColumns2AsyncAsync(
       String  restrictions,
       String  providerName,
       String  desiredColumns,
       Int32  pageSize,
       Int32  pageNumber,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

