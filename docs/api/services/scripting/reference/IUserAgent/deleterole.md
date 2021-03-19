---
uid: IUserAgent-DeleteRole
title: IUserAgent.DeleteRole event method
description: Scripting events called on the DeleteRole method on the IUserAgent service agent.
so.generated: true
keywords:
  - "netserver"
  - "scripting"
so.date: 19.03.2021
so.topic: reference
so.envir:
  - "onsite"
---
# IUserAgent.DeleteRole

Scripting events called on the <see cref='M:SuperOffice.CRM.Services.IUserAgent.DeleteRole'>DeleteRole</see> method on the <see cref='IUserAgent'>IUserAgent</see>  service agent.

## BeforeDeleteRole
```cs
    static void BeforeDeleteRole(
       Int32  roleIdToDelete,
       Int32  replacingRoleId,
       ref object  eventState
      );
```
Executes before the service method is invoked.
It can store some state in the *eventState* parameter, that is passed to the **After** and **AfterAsync** methods in this service call.
Event state is not preserved between different service calls. It is set to null at the start of each service call.
## AfterDeleteRole
```cs
    static void AfterDeleteRole(
       Int32  roleIdToDelete,
       Int32  replacingRoleId,
       ref object  eventState
      );
```
Executes after the service method has been invoked. The service waits for this method to complete before returning the result to the caller.
This service call has no return value, so there is no **returnValue** parameter
Any state you set in the **Before** method is passed in through the *eventState* parameter.
## AfterDeleteRoleAsync
```cs
    static void AfterDeleteRoleAsync(
       Int32  roleIdToDelete,
       Int32  replacingRoleId,
       ref object  eventState
      );
```
Executes after the service method is invoked, without waiting for the call to return.
The service call is not blocked waiting for this method to complete.
Any state you set in the **Before** method is passed in through the *eventState* parameter.

