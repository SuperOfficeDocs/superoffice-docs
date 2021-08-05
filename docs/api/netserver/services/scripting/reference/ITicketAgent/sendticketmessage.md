---
uid: ITicketAgent-SendTicketMessage
title: ITicketAgent.SendTicketMessage event method
description: Scripting events called on the SendTicketMessage method on the ITicketAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# ITicketAgent.SendTicketMessage

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.ITicketAgent.SendTicketMessage'>SendTicketMessage</see> method on the <see cref='ITicketAgent'>ITicketAgent</see>  service agent.

## BeforeSendTicketMessage
```cs
    static void BeforeSendTicketMessage(
       Int32  ticketMessageEntityId,
       String[]  to,
       String[]  cc,
       String[]  bcc,
       String  subject,
       Int32  replyTemplateId,
       String  gdprSource,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSendTicketMessage
```cs
    static void AfterSendTicketMessage(
       Int32  ticketMessageEntityId,
       String[]  to,
       String[]  cc,
       String[]  bcc,
       String  subject,
       Int32  replyTemplateId,
       String  gdprSource,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSendTicketMessageAsync
```cs
    static void AfterSendTicketMessageAsync(
       Int32  ticketMessageEntityId,
       String[]  to,
       String[]  cc,
       String[]  bcc,
       String  subject,
       Int32  replyTemplateId,
       String  gdprSource,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

