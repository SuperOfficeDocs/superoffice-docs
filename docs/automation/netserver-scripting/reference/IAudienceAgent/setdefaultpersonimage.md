---
uid: IAudienceAgent-SetDefaultPersonImage
title: IAudienceAgent.SetDefaultPersonImage event method
description: Scripting events called on the SetDefaultPersonImage method on the IAudienceAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IAudienceAgent.SetDefaultPersonImage

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IAudienceAgent.SetDefaultPersonImage'>SetDefaultPersonImage</see> method on the <see cref='IAudienceAgent'>IAudienceAgent</see>  service agent.

## BeforeSetDefaultPersonImage
```cs
    static void BeforeSetDefaultPersonImage(
       String  layoutName,
       Image  image,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSetDefaultPersonImage
```cs
    static void AfterSetDefaultPersonImage(
       String  layoutName,
       Image  image,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSetDefaultPersonImageAsync
```cs
    static void AfterSetDefaultPersonImageAsync(
       String  layoutName,
       Image  image,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

