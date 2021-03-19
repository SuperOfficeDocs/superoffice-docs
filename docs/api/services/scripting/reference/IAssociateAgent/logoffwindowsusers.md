---
uid: IAssociateAgent-LogOffWindowsUsers
title: IAssociateAgent.LogOffWindowsUsers event method
description: Scripting events called on the LogOffWindowsUsers method on the IAssociateAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IAssociateAgent.LogOffWindowsUsers

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IAssociateAgent.LogOffWindowsUsers'>LogOffWindowsUsers</see> method on the <see cref='IAssociateAgent'>IAssociateAgent</see>  service agent.

## BeforeLogOffWindowsUsers
```cs
    static void BeforeLogOffWindowsUsers(
       Int32[]  associateIds,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterLogOffWindowsUsers
```cs
    static void AfterLogOffWindowsUsers(
       Int32[]  associateIds,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterLogOffWindowsUsersAsync
```cs
    static void AfterLogOffWindowsUsersAsync(
       Int32[]  associateIds,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

