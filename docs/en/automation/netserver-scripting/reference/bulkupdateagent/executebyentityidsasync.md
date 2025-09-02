---
uid: bulkupdateagent-executebyentityidsasync
title: BulkUpdateAgent.ExecuteByEntityIdsAsync event method
description: Scripting events called on the ExecuteByEntityIdsAsync method on the BulkUpdateAgent service agent.
generated: true
keywords: netserver scripting
content_type: reference
envir: onsite
---
# BulkUpdateAgent.ExecuteByEntityIdsAsync

Scripting events called on the <see cref='M:IBulkUpdateAgent.ExecuteByEntityIdsAsync'>ExecuteByEntityIdsAsync</see> method on the <see cref='IBulkUpdateAgent'>IBulkUpdateAgent</see>  service agent.

## BeforeExecuteByEntityIdsAsync
```cs
    static void BeforeExecuteByEntityIdsAsync(
       FieldValueInfo[]  fieldValueInfos,
       String  tableName,
       String  context,
       String  ids,
       CancellationToken  cancellationToken,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterExecuteByEntityIdsAsync
```cs
    static void AfterExecuteByEntityIdsAsync(
       FieldValueInfo[]  fieldValueInfos,
       String  tableName,
       String  context,
       String  ids,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterExecuteByEntityIdsAsyncAsync
```cs
    static void AfterExecuteByEntityIdsAsyncAsync(
       FieldValueInfo[]  fieldValueInfos,
       String  tableName,
       String  context,
       String  ids,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

