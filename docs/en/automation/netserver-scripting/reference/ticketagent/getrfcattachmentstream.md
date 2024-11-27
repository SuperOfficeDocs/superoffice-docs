---
uid: ticketagent-getrfcattachmentstream
title: TicketAgent.GetRfcAttachmentStream event method
description: Scripting events called on the GetRfcAttachmentStream method on the TicketAgent service agent.
so.generated: true
keywords: netserver scripting
so.topic: reference
so.envir: onsite
---
# TicketAgent.GetRfcAttachmentStream

Scripting events called on the <see cref='M:ITicketAgent.GetRfcAttachmentStream'>GetRfcAttachmentStream</see> method on the <see cref='ITicketAgent'>ITicketAgent</see>  service agent.

## BeforeGetRfcAttachmentStream
```cs
    static void BeforeGetRfcAttachmentStream(
       Int32  attachmentId,
       Int32  position,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterGetRfcAttachmentStream
```cs
    static void AfterGetRfcAttachmentStream(
       Int32  attachmentId,
       Int32  position,
       ref Stream  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterGetRfcAttachmentStreamAsync
```cs
    static void AfterGetRfcAttachmentStreamAsync(
       Int32  attachmentId,
       Int32  position,
       ref Stream  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

