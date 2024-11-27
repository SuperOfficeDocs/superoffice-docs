---
uid: personagent-getpersonimages
title: PersonAgent.GetPersonImages event method
description: Scripting events called on the GetPersonImages method on the PersonAgent service agent.
so.generated: true
keywords: netserver scripting
so.topic: reference
so.envir: onsite
---
# PersonAgent.GetPersonImages

Scripting events called on the <see cref='M:IPersonAgent.GetPersonImages'>GetPersonImages</see> method on the <see cref='IPersonAgent'>IPersonAgent</see>  service agent.

## BeforeGetPersonImages
```cs
    static void BeforeGetPersonImages(
       Int32[]  personIds,
       Int32  scaledWidth,
       Int32  scaledHeight,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterGetPersonImages
```cs
    static void AfterGetPersonImages(
       Int32[]  personIds,
       Int32  scaledWidth,
       Int32  scaledHeight,
       ref PersonImage[]  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterGetPersonImagesAsync
```cs
    static void AfterGetPersonImagesAsync(
       Int32[]  personIds,
       Int32  scaledWidth,
       Int32  scaledHeight,
       ref PersonImage[]  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

