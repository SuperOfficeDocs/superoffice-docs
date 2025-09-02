---
uid: numberallocationagent-saverefcountentityasync
title: NumberAllocationAgent.SaveRefCountEntityAsync event method
description: Scripting events called on the SaveRefCountEntityAsync method on the NumberAllocationAgent service agent.
generated: true
keywords: netserver scripting
content_type: reference
envir: onsite
---
# NumberAllocationAgent.SaveRefCountEntityAsync

Scripting events called on the <see cref='M:INumberAllocationAgent.SaveRefCountEntityAsync'>SaveRefCountEntityAsync</see> method on the <see cref='INumberAllocationAgent'>INumberAllocationAgent</see>  service agent.

## BeforeSaveRefCountEntityAsync
```cs
    static void BeforeSaveRefCountEntityAsync(
       RefCountEntity  refCountEntity,
       CancellationToken  cancellationToken,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSaveRefCountEntityAsync
```cs
    static void AfterSaveRefCountEntityAsync(
       RefCountEntity  refCountEntity,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSaveRefCountEntityAsyncAsync
```cs
    static void AfterSaveRefCountEntityAsyncAsync(
       RefCountEntity  refCountEntity,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

