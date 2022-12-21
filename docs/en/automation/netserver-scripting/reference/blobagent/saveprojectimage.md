---
uid: blobagent-saveprojectimage
title: BLOBAgent.SaveProjectImage event method
description: Scripting events called on the SaveProjectImage method on the BLOBAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 11.29.2022
so.topic: reference
so.envir:
  - "onsite"
---
# BLOBAgent.SaveProjectImage

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IBLOBAgent.SaveProjectImage'>SaveProjectImage</see> method on the <see cref='IBLOBAgent'>IBLOBAgent</see>  service agent.

## BeforeSaveProjectImage
```cs
    static void BeforeSaveProjectImage(
       String  description,
       Image  image,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterSaveProjectImage
```cs
    static void AfterSaveProjectImage(
       String  description,
       Image  image,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterSaveProjectImageAsync
```cs
    static void AfterSaveProjectImageAsync(
       String  description,
       Image  image,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

