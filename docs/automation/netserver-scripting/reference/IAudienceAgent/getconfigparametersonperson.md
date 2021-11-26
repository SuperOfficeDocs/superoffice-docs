---
uid: IAudienceAgent-GetConfigParametersOnPerson
title: IAudienceAgent.GetConfigParametersOnPerson event method
description: Scripting events called on the GetConfigParametersOnPerson method on the IAudienceAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 03.19.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IAudienceAgent.GetConfigParametersOnPerson

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IAudienceAgent.GetConfigParametersOnPerson'>GetConfigParametersOnPerson</see> method on the <see cref='IAudienceAgent'>IAudienceAgent</see>  service agent.

## BeforeGetConfigParametersOnPerson
```cs
    static void BeforeGetConfigParametersOnPerson(
       Int32  personId,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterGetConfigParametersOnPerson
```cs
    static void AfterGetConfigParametersOnPerson(
       Int32  personId,
       ref AudienceConfigParameter[]  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterGetConfigParametersOnPersonAsync
```cs
    static void AfterGetConfigParametersOnPersonAsync(
       Int32  personId,
       ref AudienceConfigParameter[]  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

