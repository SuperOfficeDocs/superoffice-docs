---
uid: IAudienceAgent-GetConfigParameter
title: IAudienceAgent.GetConfigParameter event method
description: Scripting events called on the GetConfigParameter method on the IAudienceAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IAudienceAgent.GetConfigParameter

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IAudienceAgent.GetConfigParameter'>GetConfigParameter</see> method on the <see cref='IAudienceAgent'>IAudienceAgent</see>  service agent.

## BeforeGetConfigParameter
```cs
    static void BeforeGetConfigParameter(
       String  layoutName,
       String  parameterName,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterGetConfigParameter
```cs
    static void AfterGetConfigParameter(
       String  layoutName,
       String  parameterName,
       ref AudienceConfigParameter  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterGetConfigParameterAsync
```cs
    static void AfterGetConfigParameterAsync(
       String  layoutName,
       String  parameterName,
       ref AudienceConfigParameter  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

