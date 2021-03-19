---
uid: IProjectAgent-GetMyProjects
title: IProjectAgent.GetMyProjects event method
description: Scripting events called on the GetMyProjects method on the IProjectAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IProjectAgent.GetMyProjects

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IProjectAgent.GetMyProjects'>GetMyProjects</see> method on the <see cref='IProjectAgent'>IProjectAgent</see>  service agent.

## BeforeGetMyProjects
```cs
    static void BeforeGetMyProjects(
       Boolean  includeMemberProjects,
       ref object  eventState
      );
```
Executes before the service method is invoked.
The return value is not calculated yet, so this method can't affect the result.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterGetMyProjects
```cs
    static void AfterGetMyProjects(
       Boolean  includeMemberProjects,
       ref Project[]  returnValue,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
The return value has been set. The script may modify the return value by altering the **returnValue** parameter.
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterGetMyProjectsAsync
```cs
    static void AfterGetMyProjectsAsync(
       Boolean  includeMemberProjects,
       ref Project[]  returnValue,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
The async event handler cannot modify the return value of the service call.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

