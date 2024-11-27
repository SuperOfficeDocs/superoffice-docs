---
uid: listagent-deletetickettypeentity
title: ListAgent.DeleteTicketTypeEntity event method
description: Scripting events called on the DeleteTicketTypeEntity method on the ListAgent service agent.
so.generated: true
keywords: netserver scripting
so.topic: reference
so.envir: onsite
---
# ListAgent.DeleteTicketTypeEntity

Scripting events called on the <see cref='M:IListAgent.DeleteTicketTypeEntity'>DeleteTicketTypeEntity</see> method on the <see cref='IListAgent'>IListAgent</see>  service agent.

## BeforeDeleteTicketTypeEntity
```cs
    static void BeforeDeleteTicketTypeEntity(
       Int32  ticketTypeEntityId,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterDeleteTicketTypeEntity
```cs
    static void AfterDeleteTicketTypeEntity(
       Int32  ticketTypeEntityId,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterDeleteTicketTypeEntityAsync
```cs
    static void AfterDeleteTicketTypeEntityAsync(
       Int32  ticketTypeEntityId,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

