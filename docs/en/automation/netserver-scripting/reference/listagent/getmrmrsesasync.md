---
uid: listagent-getmrmrsesasync
title: ListAgent.GetMrMrsesAsync event method
description: Scripting events called on the GetMrMrsesAsync method on the ListAgent service agent.
generated: true
keywords: netserver scripting
content_type: reference
envir: onsite
---
# ListAgent.GetMrMrsesAsync

Scripting events called on the <see cref='M:IListAgent.GetMrMrsesAsync'>GetMrMrsesAsync</see> method on the <see cref='IListAgent'>IListAgent</see>  service agent.

## BeforeGetMrMrsesAsync
```cs
    static void BeforeGetMrMrsesAsync(
       CancellationToken  cancellationToken,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterGetMrMrsesAsync
```cs
    static void AfterGetMrMrsesAsync(
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterGetMrMrsesAsyncAsync
```cs
    static void AfterGetMrMrsesAsyncAsync(
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

