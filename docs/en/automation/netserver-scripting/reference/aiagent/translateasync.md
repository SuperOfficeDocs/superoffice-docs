---
uid: aiagent-translateasync
title: AIAgent.TranslateAsync event method
description: Scripting events called on the TranslateAsync method on the AIAgent service agent.
generated: true
keywords: netserver scripting
content_type: reference
envir: onsite
---
# AIAgent.TranslateAsync

Scripting events called on the <see cref='M:IAIAgent.TranslateAsync'>TranslateAsync</see> method on the <see cref='IAIAgent'>IAIAgent</see>  service agent.

## BeforeTranslateAsync
```cs
    static void BeforeTranslateAsync(
       String  text,
       String  targetLanguage,
       CancellationToken  cancellationToken,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterTranslateAsync
```cs
    static void AfterTranslateAsync(
       String  text,
       String  targetLanguage,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterTranslateAsyncAsync
```cs
    static void AfterTranslateAsyncAsync(
       String  text,
       String  targetLanguage,
       CancellationToken  cancellationToken,
       ref Task`1  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

