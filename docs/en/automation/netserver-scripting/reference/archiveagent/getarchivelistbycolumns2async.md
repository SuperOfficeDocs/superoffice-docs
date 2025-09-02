---
uid: archiveagent-getarchivelistbycolumns2async
title: ArchiveAgent.GetArchiveListByColumns2Async event method
description: Scripting events called on the GetArchiveListByColumns2Async method on the ArchiveAgent service agent.
generated: true
keywords: netserver scripting
content_type: reference
envir: onsite
---
# ArchiveAgent.GetArchiveListByColumns2Async

Scripting events called on the <see cref='M:IArchiveAgent.GetArchiveListByColumns2Async'>GetArchiveListByColumns2Async</see> method on the <see cref='IArchiveAgent'>IArchiveAgent</see>  service agent.

## BeforeGetArchiveListByColumns2Async
```cs
    static void BeforeGetArchiveListByColumns2Async(
       String  providerName,
       String  columns,
       String  sortOrder,
       String  restrictions,
       String  entities,
       Int32  page,
       Int32  pageSize,
       CancellationToken  cancellationToken,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterGetArchiveListByColumns2Async
```cs
    static void AfterGetArchiveListByColumns2Async(
       String  providerName,
       String  columns,
       String  sortOrder,
       String  restrictions,
       String  entities,
       Int32  page,
       Int32  pageSize,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterGetArchiveListByColumns2AsyncAsync
```cs
    static void AfterGetArchiveListByColumns2AsyncAsync(
       String  providerName,
       String  columns,
       String  sortOrder,
       String  restrictions,
       String  entities,
       Int32  page,
       Int32  pageSize,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

