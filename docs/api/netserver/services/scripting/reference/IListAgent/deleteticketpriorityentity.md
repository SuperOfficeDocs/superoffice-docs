---
uid: IListAgent-DeleteTicketPriorityEntity
title: IListAgent.DeleteTicketPriorityEntity event method
description: Scripting events called on the DeleteTicketPriorityEntity method on the IListAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IListAgent.DeleteTicketPriorityEntity

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IListAgent.DeleteTicketPriorityEntity'>DeleteTicketPriorityEntity</see> method on the <see cref='IListAgent'>IListAgent</see>  service agent.

## BeforeDeleteTicketPriorityEntity
```cs
    static void BeforeDeleteTicketPriorityEntity(
       Int32  ticketPriorityEntityId,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterDeleteTicketPriorityEntity
```cs
    static void AfterDeleteTicketPriorityEntity(
       Int32  ticketPriorityEntityId,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterDeleteTicketPriorityEntityAsync
```cs
    static void AfterDeleteTicketPriorityEntityAsync(
       Int32  ticketPriorityEntityId,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

