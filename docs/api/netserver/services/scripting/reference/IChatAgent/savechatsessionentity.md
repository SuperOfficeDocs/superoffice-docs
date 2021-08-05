---
uid: IChatAgent-SaveChatSessionEntity
title: IChatAgent.SaveChatSessionEntity event method
description: Scripting events called on the SaveChatSessionEntity method on the IChatAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IChatAgent.SaveChatSessionEntity

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IChatAgent.SaveChatSessionEntity'>SaveChatSessionEntity</see> method on the <see cref='IChatAgent'>IChatAgent</see>  service agent.

## BeforeSaveChatSessionEntity
```cs
    static void BeforeSaveChatSessionEntity(
       ChatSessionEntity  chatSessionEntity,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSaveChatSessionEntity
```cs
    static void AfterSaveChatSessionEntity(
       ChatSessionEntity  chatSessionEntity,
       ref ChatSessionEntity  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSaveChatSessionEntityAsync
```cs
    static void AfterSaveChatSessionEntityAsync(
       ChatSessionEntity  chatSessionEntity,
       ref ChatSessionEntity  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

