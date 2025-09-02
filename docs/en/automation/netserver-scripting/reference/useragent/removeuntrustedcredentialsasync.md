---
uid: useragent-removeuntrustedcredentialsasync
title: UserAgent.RemoveUntrustedCredentialsAsync event method
description: Scripting events called on the RemoveUntrustedCredentialsAsync method on the UserAgent service agent.
generated: true
keywords: netserver scripting
content_type: reference
envir: onsite
---
# UserAgent.RemoveUntrustedCredentialsAsync

Scripting events called on the <see cref='M:IUserAgent.RemoveUntrustedCredentialsAsync'>RemoveUntrustedCredentialsAsync</see> method on the <see cref='IUserAgent'>IUserAgent</see>  service agent.

## BeforeRemoveUntrustedCredentialsAsync
```cs
    static void BeforeRemoveUntrustedCredentialsAsync(
       String  type,
       String  publicValue,
       CancellationToken  cancellationToken,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterRemoveUntrustedCredentialsAsync
```cs
    static void AfterRemoveUntrustedCredentialsAsync(
       String  type,
       String  publicValue,
       CancellationToken  cancellationToken,
       ref Task  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterRemoveUntrustedCredentialsAsyncAsync
```cs
    static void AfterRemoveUntrustedCredentialsAsyncAsync(
       String  type,
       String  publicValue,
       CancellationToken  cancellationToken,
       ref Task  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

