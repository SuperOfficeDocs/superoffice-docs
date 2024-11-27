---
uid: diagnosticsagent-sendsystemmessage
title: DiagnosticsAgent.SendSystemMessage event method
description: Scripting events called on the SendSystemMessage method on the DiagnosticsAgent service agent.
so.generated: true
keywords: netserver scripting
so.topic: reference
so.envir: onsite
---
# DiagnosticsAgent.SendSystemMessage

Scripting events called on the <see cref='M:IDiagnosticsAgent.SendSystemMessage'>SendSystemMessage</see> method on the <see cref='IDiagnosticsAgent'>IDiagnosticsAgent</see>  service agent.

## BeforeSendSystemMessage
```cs
    static void BeforeSendSystemMessage(
       String  systemMessageId,
       Int32  associateId,
       String  markdownMessage,
       DateTime  expire,
       SystemMessageType  type,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSendSystemMessage
```cs
    static void AfterSendSystemMessage(
       String  systemMessageId,
       Int32  associateId,
       String  markdownMessage,
       DateTime  expire,
       SystemMessageType  type,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSendSystemMessageAsync
```cs
    static void AfterSendSystemMessageAsync(
       String  systemMessageId,
       Int32  associateId,
       String  markdownMessage,
       DateTime  expire,
       SystemMessageType  type,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

