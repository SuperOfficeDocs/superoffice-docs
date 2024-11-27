---
uid: pocketagent-notificationshandled
title: PocketAgent.NotificationsHandled event method
description: Scripting events called on the NotificationsHandled method on the PocketAgent service agent.
so.generated: true
keywords: netserver scripting
so.topic: reference
so.envir: onsite
---
# PocketAgent.NotificationsHandled

Scripting events called on the <see cref='M:IPocketAgent.NotificationsHandled'>NotificationsHandled</see> method on the <see cref='IPocketAgent'>IPocketAgent</see>  service agent.

## BeforeNotificationsHandled
```cs
    static void BeforeNotificationsHandled(
       NotificationEvent[]  notificationEvents,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterNotificationsHandled
```cs
    static void AfterNotificationsHandled(
       NotificationEvent[]  notificationEvents,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterNotificationsHandledAsync
```cs
    static void AfterNotificationsHandledAsync(
       NotificationEvent[]  notificationEvents,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

