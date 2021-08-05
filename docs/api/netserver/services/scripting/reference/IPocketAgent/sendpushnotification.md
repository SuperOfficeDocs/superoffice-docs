---
uid: IPocketAgent-SendPushNotification
title: IPocketAgent.SendPushNotification event method
description: Scripting events called on the SendPushNotification method on the IPocketAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IPocketAgent.SendPushNotification

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IPocketAgent.SendPushNotification'>SendPushNotification</see> method on the <see cref='IPocketAgent'>IPocketAgent</see>  service agent.

## BeforeSendPushNotification
```cs
    static void BeforeSendPushNotification(
       Int32[]  associateIds,
       PocketNotificationMessage  message,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSendPushNotification
```cs
    static void AfterSendPushNotification(
       Int32[]  associateIds,
       PocketNotificationMessage  message,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSendPushNotificationAsync
```cs
    static void AfterSendPushNotificationAsync(
       Int32[]  associateIds,
       PocketNotificationMessage  message,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

